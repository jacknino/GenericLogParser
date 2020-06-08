using System.Configuration;
using System.Text;

namespace GenericLogParser.FilterExtensions
{
    public class FilterExtension : ConfigurationElement
    {
        private const string DescriptionAttributeName = "Description";
        private const string ExtensionsAttributeName = "Extensions";

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}", Description);
            
            return result.ToString();
        }

        [ConfigurationProperty(DescriptionAttributeName, DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Description
        {
            get { return (string)base[DescriptionAttributeName]; }
            set { base[DescriptionAttributeName] = value; }
        }

        [ConfigurationProperty(ExtensionsAttributeName, DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Extensions
        {
            get { return (string)base[ExtensionsAttributeName]; }
            set { base[ExtensionsAttributeName] = value; }
        }
    }
}
