using System;
using System.Configuration;

namespace GenericLogParser.SavedExpressions
{
    public class SavedExpressionsSection : ConfigurationSection
    {
        private const string SavedExpressionsSectionName = "SavedExpressions";

        /// <summary>
        /// Gets the exe path.
        /// </summary>
        /// <returns>A string to the full path of the executable file for "msvc_s2sinterface".</returns>
        private static string GetExePath()
        {
            //When running this code from Resharper, the CodeBase property returns the URL path. 
            //So we need to convert this to the physical path by replacing the "file:\\" with empty space
            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " "),
                "GenericLogParser.exe");
        }

        /// <summary>
        /// Adds the specified exe path.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <param name="newSavedExpression">The new system configuration data.</param>
        /// <returns></returns>
        public static SavedExpressionCollection Add(string exePath, SavedExpression newSavedExpression)
        {
            Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
            SavedExpressionsSection savedExpressions = (SavedExpressionsSection)fileConfiguration.GetSection(SavedExpressionsSectionName);

            savedExpressions.SavedExpressions.Add(newSavedExpression);
            fileConfiguration.Save();
            return savedExpressions.SavedExpressions;
        }

        /// <summary>
        /// Adds the specified new system configuration data.
        /// </summary>
        /// <param name="newSavedExpression">The new system configuration data.</param>
        /// <returns></returns>
        public static SavedExpressionCollection Add(SavedExpression newSavedExpression)
        {
            string exePath = GetExePath();

            return Add(exePath, newSavedExpression);
        }

        /// <summary>
        /// Removes the specified exe path.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <param name="name">The connection id.</param>
        /// <returns></returns>
        public static SavedExpressionCollection Remove(string exePath, string name)
        {
            Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
            SavedExpressionsSection savedExpressions = (SavedExpressionsSection)fileConfiguration.GetSection(SavedExpressionsSectionName);

            savedExpressions.SavedExpressions.Remove(name);
            fileConfiguration.Save();
            return savedExpressions.SavedExpressions;
        }

        /// <summary>
        /// Removes the specified system id.
        /// </summary>
        /// <param name="name">The system id.</param>
        /// <returns></returns>
        public static SavedExpressionCollection Remove(string name)
        {
            string exePath = GetExePath();

            return Remove(exePath, name);
        }

        /// <summary>
        /// Gets the SavedExpressions section.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <returns></returns>
        public static SavedExpressionsSection GetSavedExpressionsSection(string exePath)
        {
            try
            {
                Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
                SavedExpressionsSection savedExpressions = (SavedExpressionsSection)fileConfiguration.GetSection(SavedExpressionsSectionName);

                if (savedExpressions == null)
                    throw new Exception(string.Format("Failed to get SavedExpressions sections from {0}", exePath));

                return savedExpressions;
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
        public static SavedExpressionsSection GetSystemsSection()
        {
            return GetSavedExpressionsSection(GetExePath());
        }

        /// <summary>
        /// Gets the Saved Configurations.
        /// </summary>
        /// <param name="exePath">The exe path.</param>
        /// <returns></returns>
        public static SavedExpressionCollection GetSavedExpressions(string exePath)
        {
            return GetSavedExpressionsSection(exePath).SavedExpressions;
        }

        /// <summary>
        /// Gets the systems.
        /// </summary>
        /// <returns></returns>
        public static SavedExpressionCollection GetSavedExpressions()
        {
            return GetSavedExpressions(GetExePath());
        }

        //public override string ToString()
        //{
        //    return this.Name;
        //}

        /// <summary>
        /// Gets the systems.
        /// </summary>
        /// <value>The systems.</value>
        [ConfigurationProperty("", IsDefaultCollection = true)]
        //[SystemsIdsValidator()]
        public SavedExpressionCollection SavedExpressions
        {
            get
            {
                return (SavedExpressionCollection)base[""];
            }
        }
    }
}
