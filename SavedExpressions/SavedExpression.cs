using System.Configuration;
using System.Text;

namespace GenericLogParser.SavedExpressions
{
    public class SavedExpression : ConfigurationElement
    {
        private const string NameAttributeName = "Name";
        private const string HeaderExpressionAttributeName = "HeaderExpression";

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0} ({1})", Name, HeaderExpression);
            
            return result.ToString();
        }

        [ConfigurationProperty(NameAttributeName, DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)base[NameAttributeName]; }
            set { base[NameAttributeName] = value; }
        }

        [ConfigurationProperty(HeaderExpressionAttributeName, DefaultValue = "", IsRequired = true, IsKey = true)]
        public string HeaderExpression
        {
            get { return (string)base[HeaderExpressionAttributeName]; }
            set { base[HeaderExpressionAttributeName] = value; }
        }
    }
}
