using System.Collections.Generic;

namespace GenericLogParser
{
    public class SaveOptionsData
    {
        public SaveOptionsData()
        {

        }

        public SaveOptionsData(
            string headerExpression,
            List<string> includeStatements,
            List<string> excludeStatements,
            string inputFormat,
            string outputFormat,
            string outputFileSuffix,
            string description,
            string comment,
            string exampleInput)
        {
            HeaderExpression = headerExpression;
            IncludeStatements = includeStatements;
            ExcludeStatements = excludeStatements;
            InputFormat = inputFormat;
            OutputFormat = outputFormat;
            OutputFileSuffix = outputFileSuffix;
            Description = description;
            Comment = comment;
            ExampleInput = exampleInput;
        }

        public string HeaderExpression { get; set; }
        public List<string> IncludeStatements { get; set; }
        public List<string> ExcludeStatements { get; set; }
        public string InputFormat { get; set; }
        public string OutputFormat { get; set; }
        public string OutputFileSuffix { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string ExampleInput { get; set; }
    }
}
