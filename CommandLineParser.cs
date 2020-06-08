using System.Collections.Generic;

namespace GenericLogParser
{
    class CommandLineParser : Dictionary<string, string>
    {
        private static readonly CommandLineParser _commandLineParser = new CommandLineParser();

        private CommandLineParser() 
        { 
        }

        /// <summary>
        /// Singleton access
        /// </summary>
        public static CommandLineParser Instance
        {
            get { return _commandLineParser; }
        }

        // Originally I had this as a static in the ParseParam function but then
        // there was no way to reinitialize it which meant if you called ParseCommandLine
        // twice you could get some goofy results.  By making it a member variable like
        // this ParseCommandLine can reset it every time it's called.
        //private string _lastFlag;

        // What this parameter is for is if the first value on the command line is
        // not a flag, if this value is set to something other than "" then this
        // value will be used as the flag name.  For example:  if _firstParameterIfNoFlag
        // is set to "InputFile" then if the first thing on the command line is
        // C:\blah.txt then the InputFile parameter will be set to "C:\blah.txt"
        // If this first value on the command line is a flag (/something) then
        // _firstParameterIfNoFlag will not be used.
        private string _firstParameterIfNoFlag;

        public string FirstParameterIfNoFlag
        {
            get { return _firstParameterIfNoFlag; }
            set { _firstParameterIfNoFlag = value; }
        }

        public void ParseCommandLine(string[] commandLine, string firstParameterIfNoFlag)
        {
            FirstParameterIfNoFlag = firstParameterIfNoFlag;
            ParseCommandLine(commandLine);
        }

        // TODO:  Don't think all of these have been tested since move to .Net
        public void ParseCommandLine(string[] commandLine)
        {
            bool lastWasFlag = false;
            string lastFlag = "";

            foreach (string item in commandLine)
            {
                if (IsFlag(item))
                {
                    if (lastWasFlag)
                        Add(lastFlag, "1");

                    lastWasFlag = true;
                    lastFlag = item.Substring(1);
                }
                else
                {
                    if (lastWasFlag)
                        Add(lastFlag, item);
                    else if (Count == 0 && !string.IsNullOrEmpty(_firstParameterIfNoFlag))
                        Add(_firstParameterIfNoFlag, item);
                    else
                        Add(item, item);

                    lastWasFlag = false;
                }
            }

            // If we got here and the last thing was a flag we need to add it.
            if (lastWasFlag)
                Add(lastFlag, "1");
        }

        private bool IsFlag(string item)
        {
            string firstChar = item.Substring(0, 1);
            return (firstChar == "/" || firstChar == "-");
        }
    }
}
