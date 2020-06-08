using System.Collections.Generic;

namespace GenericLogParser
{
    internal class ParseInfo
    {
        public ParseInfo(
            LogParser logParser,
            List<string> inputFiles, 
            string outputFile, 
            string headerRowSearchExpression,
            string searchIncludeExpression,
            string searchExcludeExpression,
            string inputFormat,
            string outputFormat)
        {
            LogParser = logParser;
            InputFiles = inputFiles;
            OutputFile = outputFile;
            HeaderRowSearchExpression = headerRowSearchExpression;
            SearchIncludeExpression = searchIncludeExpression;
            SearchExcludeExpression = searchExcludeExpression;
            InputFormat = inputFormat;
            OutputFormat = outputFormat;
        }

        public LogParser LogParser { get; set; }
        public List<string> InputFiles { get; set; }
        public string OutputFile { get; set; }
        public string SearchIncludeExpression { get; set; }
        public string SearchExcludeExpression { get; set; }
        public string HeaderRowSearchExpression { get; set; }
        public string InputFormat { get; set; }
        public string OutputFormat { get; set; }
    }
}
