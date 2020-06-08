using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Linq;

namespace GenericLogParser
{
	/// <summary>
	/// This class does the actual parsing of the files.
	/// </summary>
	public class LogParser
	{
		private const long DefaultBytesProcessedEventIncrement = 1000000;

		private bool _continueProcessing = false;
		private bool _processing = false;

		private long _bytesProcessedEventIncrement;

		private long _totalBytesProcessed;
		private int _totalRecordsFound;

		public delegate void OnBytesProcessedEvent(
			long fileBytesProcessed, 
			int fileRecordsFound,
			long totalBytesProcessed,
			int totalRecordsFound);
		public delegate void OnProcessingCompleteEvent();
		public delegate void OnReportStatusEvent(string statusText);

		public event OnBytesProcessedEvent OnBytesProcessed;
		public event OnProcessingCompleteEvent OnProcessingComplete;
		public event OnReportStatusEvent OnReportStatus;

		public LogParser()
		{
			_bytesProcessedEventIncrement = DefaultBytesProcessedEventIncrement;
		}

		public bool IsProcessing
		{
			get { return _processing; }
		}

		public long BytesProcessedEventIncrement
		{
			get { return _bytesProcessedEventIncrement; }
			set { _bytesProcessedEventIncrement = value; }
		}

		public void StopProcessing()
		{
			_continueProcessing = false;
		}

		public bool StartProcessing(
			List<string> inputFiles,
			string outputFile,
            string headerRowSearchExpression,
            List<string> searchIncludeList,
            List<string> searchExcludeList,
            string inputFormat,
            string outputFormat)
		{
			if (_processing)
				return false;

			_processing = true;
			_continueProcessing = true;

			string searchIncludeExpression = BuildSearchExpression(searchIncludeList);
		    string searchExcludeExpression = BuildSearchExpression(searchExcludeList);

            ParseInfo parseInfo = new ParseInfo(this, inputFiles, outputFile, headerRowSearchExpression, searchIncludeExpression, searchExcludeExpression, inputFormat, outputFormat);

			OnReportStatus("Starting processing...");
			OnReportStatus("Output File: " + outputFile);
			OnReportStatus("Search Expression:  " + searchIncludeExpression);
			ThreadPool.QueueUserWorkItem(ParseFileThread, parseInfo);

			return true;
		}

		private static void ParseFileThread(Object stateInfo)
		{
			ParseInfo parseInfo = (ParseInfo)stateInfo;
            parseInfo.LogParser.ParseFiles(parseInfo);
		}

		private void ParseFiles(ParseInfo parseInfo)
		{
			_totalBytesProcessed = 0;
			_totalRecordsFound = 0;

            ParseInputFiles(parseInfo);

		    _processing = false;

            if (_continueProcessing)
            {
                OnReportStatus("Processing complete.  "
                    + _totalBytesProcessed + " bytes processed, "
                    + _totalRecordsFound + " records found.");
            }
            else
            {
                OnReportStatus("Processing canceled.");
            }

		    if (OnProcessingComplete != null)
				OnProcessingComplete();
		}

	    private void ParseInputFiles(ParseInfo parseInfo)
	    {
	        bool firstFile = true;
	        foreach (string inputFile in parseInfo.InputFiles)
	        {
	            ParseFile(
	                inputFile, 
                    parseInfo,
	                firstFile);
	            firstFile = false;

	            if (!_continueProcessing)
	                break;
	        }
	    }

	    private void ParseFile(
			string inputFile, 
            ParseInfo parseInfo,
			bool firstFile)
		{
			// Open file
			// Read in line
			// Search for header
			// If match, read into memory until next header or EOF
			// Search what's in memory for search expression
			// If match, output what's in memory

			OnReportStatus("Processing Input File: " + inputFile);

			long fileBytesProcessed = 0;
			long nextBytesToReport = _bytesProcessedEventIncrement;
			int fileRecordsFound = 0;

			StreamReader streamReader = File.OpenText(inputFile);
			StreamWriter streamWriter = firstFile ? File.CreateText(parseInfo.OutputFile) : File.AppendText(parseInfo.OutputFile);

            try
            {
                string currentBlob = "";
                while (streamReader.Peek() >= 0 && _continueProcessing)
                {
                    string currentLine = streamReader.ReadLine();

                    string textToOutput;
                    if (ParseLineAndDetermineIfBlobIsMatch(
                        ref currentBlob, 
                        currentLine, 
                        parseInfo.HeaderRowSearchExpression,
                        parseInfo.SearchIncludeExpression, 
                        parseInfo.SearchExcludeExpression,
                        out textToOutput))
                    {
                        string formattedTextToOutput = FormatOutputText(textToOutput, parseInfo.InputFormat, parseInfo.OutputFormat);
                        streamWriter.WriteLine(formattedTextToOutput);
                        ++fileRecordsFound;
                        ++_totalRecordsFound;
                    }

                    fileBytesProcessed += currentLine.Length;
                    _totalBytesProcessed += currentLine.Length;

                    nextBytesToReport = ReportBytesProcessedIfTime(fileRecordsFound, fileBytesProcessed, nextBytesToReport);
                }
            }
            finally
            {
                streamReader.Close();
                streamWriter.Close();
            }

	        OnReportStatus("Finished processing " + inputFile + ".  " 
				+ fileBytesProcessed + " (Total " + _totalBytesProcessed
				+ ") bytes processed, " + fileRecordsFound 
				+ " (Total " + _totalRecordsFound + ") records found.");
		}

	    private string FormatOutputText(string textToOutput, string inputFormat, string outputFormat)
	    {
	        if (string.IsNullOrEmpty(inputFormat)
	            || string.IsNullOrEmpty(outputFormat))
	        {
	            return textToOutput;
	        }

            List<Tuple<string, string>> inputOutputFormats = GetInputOutputFormatsFromStrings(inputFormat, outputFormat);
            string formattedOutputText = FormatText(textToOutput, inputOutputFormats);
	        return formattedOutputText;
	    }

        static string FormatWithLookaheadToNextOutput(string inputText, string inputFormat, string currentOutputFormat, ref string nextOutputFormat)
        {
            string result = "";
            Regex regex = new Regex(inputFormat, RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(inputText);
            for (int matchNumber = 0; matchNumber < matches.Count; ++matchNumber)
            {
                Match match = matches[matchNumber];

                result += regex.Replace(match.Value, currentOutputFormat);

                // Take output format and first replace anything that matches from our first set so instead of ${Date} ${Data} it would be 2017-05-17 ${Data}
                // Then for each match from secondInputFormat, do a replace with the new outputFormat and add that to our result
                if (nextOutputFormat != null)
                {
                    Dictionary<string, string> groupNameReplacements = GetGroupNameValueDictionary(regex.GetGroupNames(), match.Groups);
                    nextOutputFormat = ReplaceTokens(nextOutputFormat, groupNameReplacements);
                }
            }

            return result;
        }

        private static string ReplaceTokens(string formatString, Dictionary<string, string> tokens)
        {
            var regexRegular = new Regex(String.Join("|", tokens.Keys.Select(key => Regex.Escape(key))));
            var replaced = regexRegular.Replace(formatString, value => tokens[value.Value]);

            return replaced;
        }

        private static Dictionary<string, string> GetGroupNameValueDictionary(string[] groupNames, GroupCollection matchGroups)
        {
            Dictionary<string, string> groupNameValueDictionary = new Dictionary<string, string>();
            foreach (string groupName in groupNames)
            {
                var group = matchGroups[groupName];
                if (group.Success)
                    groupNameValueDictionary.Add("${" + groupName + "}", group.Value);
            }

            return groupNameValueDictionary;
        }

        private static string FormatText(string input, List<Tuple<string, string>> inputOutputFormats)
        {
            string output = input;
            string nextOutputFormat = inputOutputFormats[0].Item2;
            for (int index = 0; index < inputOutputFormats.Count; ++index)
            {
                string currentInputFormat = inputOutputFormats[index].Item1;
                string currentOutputFormat = nextOutputFormat;
                nextOutputFormat = (index < inputOutputFormats.Count - 1) ? inputOutputFormats[index + 1].Item2 : null;
                output = FormatWithLookaheadToNextOutput(output, currentInputFormat, currentOutputFormat, ref nextOutputFormat);
            }

            return output;
        }

        private static List<Tuple<string, string>> GetInputOutputFormatsFromStrings(string inputFormatText, string outputFormatText)
        {
            // outputFormatText will either just be the output format by itself
            // or will have the output format and then one or more pairs of.  This will look like:
            // {{OutputFormat}},{{InputFormat}}=>{{OutputFormat}} repeat
            List<Tuple<string, string>> inputOutputFormatsList = new List<Tuple<string, string>>();

            const string regexFormat = @"^{{(?<OutputFormat>(.+))}}(?<InputOutputFormats>(,([ ]*){{(.+)}}[ ]*=>[ ]*{{(.+)}}))$";
            Match match = Regex.Match(outputFormatText, regexFormat, RegexOptions.Singleline);
            if (!outputFormatText.StartsWith("{{") || !match.Success)
            {
                inputOutputFormatsList.Add(new Tuple<string, string>(inputFormatText, outputFormatText));
                return inputOutputFormatsList;
            }

            inputOutputFormatsList.Add(new Tuple<string, string>(inputFormatText, match.Groups["OutputFormat"].Value));
            string inputOutputFormats = match.Groups["InputOutputFormats"].Value;
            if (!string.IsNullOrEmpty(inputOutputFormats))
            {
                const string inputOutputFormat = @",[ ]*{{(?<InputFormat>(.+))}}[ ]*=>[ ]*{{(?<OutputFormat>(.+))}}";
                MatchCollection inputOutputMatches = Regex.Matches(inputOutputFormats, inputOutputFormat);
                foreach (Match inputOutputMatch in inputOutputMatches)
                {
                    inputOutputFormatsList.Add(new Tuple<string, string>(inputOutputMatch.Groups["InputFormat"].Value, inputOutputMatch.Groups["OutputFormat"].Value));
                }
            }

            return inputOutputFormatsList;
        }

        private bool ParseLineAndDetermineIfBlobIsMatch(
            ref string currentBlob, 
            string currentLine,
            string headerRowSearchExpression,
            string searchIncludeExpression, 
            string searchExcludeExpression,
            out string textToOutput)
        {
            // For log4net files beginning of debug/error statement looks like yyyy-mm-dd hh:mm:ss,mmm
            //const string headerRowSearchExpression = "((\\d{4})-(\\d\\d)-(\\d\\d) (\\d\\d)\\:(\\d\\d)\\:(\\d\\d)\\,(\\d{3}))";

            bool foundMatch = false;
            textToOutput = "";

            if (FindExpression(currentLine, headerRowSearchExpression) != -1)
            {
                if (currentBlob != "")
                {
                    // If the contents isn't part of the excluded expression 
                    // and it is part of the included expression
                    // then we want it to be included in the output.
                    if ((string.IsNullOrEmpty(searchExcludeExpression) || FindExpression(currentBlob, searchExcludeExpression) == -1)
                        && (string.IsNullOrEmpty(searchIncludeExpression) || FindExpression(currentBlob, searchIncludeExpression) != -1))
                    {
                        foundMatch = true;
                        textToOutput = currentBlob;
                    }

                    currentBlob = "";
                }
            }

            if (currentBlob != "")
                currentBlob += "\r\n";
            currentBlob += currentLine;

            return foundMatch;
        }

        private long ReportBytesProcessedIfTime(int fileRecordsFound, long fileBytesProcessed, long nextBytesToReport)
	    {
	        if ((OnBytesProcessed != null) && (fileBytesProcessed > nextBytesToReport))
	        {
	            OnBytesProcessed(
	                fileBytesProcessed, 
	                fileRecordsFound, 
	                _totalBytesProcessed, 
	                _totalRecordsFound);
	            nextBytesToReport += _bytesProcessedEventIncrement;
	        }

            return nextBytesToReport;
	    }

        private string BuildSearchExpression(List<string> searchList)
		{
			string expression = "";

			foreach (string search in searchList)
			{
				if (expression != "")
					expression += "|";

				expression += "(" + search + ")";
			}

			return expression;
		}

		private int FindExpression(string expression, string searchString)
		{
            Match match = Regex.Match(expression, searchString);

            return (match.Success ? match.Index : -1);
		}
	}
}
