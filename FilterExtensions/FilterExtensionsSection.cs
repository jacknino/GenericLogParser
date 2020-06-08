using System;
using System.Configuration;

namespace GenericLogParser.FilterExtensions
{
    public class FilterExtensionsSection : ConfigurationSection
    {
        private const string FilteredExtensionsSectionName = "FilterExtensions";

        protected static string GetExePath()
        {
            //When running this code from Resharper, the CodeBase property returns the URL path. 
            //So we need to convert this to the physical path by replacing the "file:\\" with empty space
            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " "),
                "GenericLogParser.exe");
        }

        public static FilterExtensionCollection Add(string exePath, FilterExtension newSavedExpression)
        {
            Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
            FilterExtensionsSection savedExpressions = (FilterExtensionsSection)fileConfiguration.GetSection(FilteredExtensionsSectionName);

            savedExpressions.FilterExtensions.Add(newSavedExpression);
            fileConfiguration.Save();
            return savedExpressions.FilterExtensions;
        }

        public static FilterExtensionCollection Add(FilterExtension element)
        {
            string exePath = GetExePath();

            return Add(exePath, element);
        }

        /// <summary>
        /// Removes the specified exe path.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <param name="name">The connection id.</param>
        /// <returns></returns>
        public static FilterExtensionCollection Remove(string exePath, string name)
        {
            Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
            FilterExtensionsSection section = (FilterExtensionsSection)fileConfiguration.GetSection(FilteredExtensionsSectionName);

            section.FilterExtensions.Remove(name);
            fileConfiguration.Save();
            return section.FilterExtensions;
        }

        /// <summary>
        /// Removes the specified system id.
        /// </summary>
        /// <param name="name">The system id.</param>
        /// <returns></returns>
        public static FilterExtensionCollection Remove(string name)
        {
            string exePath = GetExePath();

            return Remove(exePath, name);
        }

        /// <summary>
        /// Gets the SavedExpressions section.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <returns></returns>
        public static FilterExtensionsSection GetSavedExpressionsSection(string exePath)
        {
            try
            {
                Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
                FilterExtensionsSection section = (FilterExtensionsSection)fileConfiguration.GetSection(FilteredExtensionsSectionName);

                if (section == null)
                    throw new Exception(string.Format("Failed to get SavedExpressions sections from {0}", exePath));

                return section;
            }
            catch (Exception ex)
            {
                throw new Exception("Error trying to load configuration file for " + exePath, ex);
            }
        }

        /// <summary>
        /// Gets the SavedExpressions section.
        /// </summary>
        /// <returns></returns>
        public static FilterExtensionsSection GetSystemsSection()
        {
            return GetSavedExpressionsSection(GetExePath());
        }

        /// <summary>
        /// Gets the Saved Configurations.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <returns></returns>
        public static FilterExtensionCollection GetFilterExtensions(string exePath)
        {
            return GetSavedExpressionsSection(exePath).FilterExtensions;
        }

        /// <summary>
        /// Gets the systems.
        /// </summary>
        /// <returns></returns>
        public static FilterExtensionCollection GetFilterExtensions()
        {
            return GetFilterExtensions(GetExePath());
        }

        /// <summary>
        /// Gets the systems.
        /// </summary>
        /// <value>The systems.</value>
        [ConfigurationProperty("", IsDefaultCollection = true)]
        //[SystemsIdsValidator()]
        public FilterExtensionCollection FilterExtensions
        {
            get
            {
                return (FilterExtensionCollection)base[""];
            }
        }
    }
}
