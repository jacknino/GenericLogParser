//using System;
//using System.Configuration;

//namespace GenericLogParser
//{
//    public abstract class ConfigurationSectionBase<TElementType, TCollectionType> : ConfigurationSection
//        where TElementType : ConfigurationElement
//        where TCollectionType : ConfigurationElementCollection
//    {
//        private const string SavedExpressionsSectionName = "FilterExtensions";

//        protected static string GetExePath()
//        {
//            //When running this code from Resharper, the CodeBase property returns the URL path. 
//            //So we need to convert this to the physical path by replacing the "file:\\" with empty space
//            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(
//                System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", " "),
//                "GenericLogParser.exe");
//        }

//        public static TCollectionType Add<TSectionType>(string exePath, TElementType newSavedExpression)
//            where TSectionType : ConfigurationSection
//        {
//            Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
//            TSectionType savedExpressions = (TSectionType)fileConfiguration.GetSection(SavedExpressionsSectionName);

//            savedExpressions.SavedExpressions.Add(newSavedExpression);
//            fileConfiguration.Save();
//            return savedExpressions.SavedExpressions;
//        }

//        public static TCollectionType Add(TElementType newSavedExpression)
//        {
//            string exePath = GetExePath();

//            return Add(exePath, newSavedExpression);
//        }

//        /// <summary>
//        /// Removes the specified exe path.
//        /// </summary>
//        /// <param name="exePath">The exe path.</param>
//        /// <param name="name">The connection id.</param>
//        /// <returns></returns>
//        public static TCollectionType Remove<TSectionType>(string exePath, string name)
//            where TSectionType : ConfigurationSection
//        {
//            Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
//            TSectionType savedExpressions = (TSectionType)fileConfiguration.GetSection(SavedExpressionsSectionName);

//            savedExpressions.SavedExpressions.Remove(name);
//            fileConfiguration.Save();
//            return savedExpressions.SavedExpressions;
//        }

//        /// <summary>
//        /// Removes the specified system id.
//        /// </summary>
//        /// <param name="name">The system id.</param>
//        /// <returns></returns>
//        public static TCollectionType Remove(string name)
//        {
//            string exePath = GetExePath();

//            return Remove(exePath, name);
//        }

//        /// <summary>
//        /// Gets the SavedExpressions section.
//        /// </summary>
//        /// <param name="exePath">The exe path.</param>
//        /// <returns></returns>
//        public static TSectionType GetSavedExpressionsSection<TSectionType>(string exePath)
//            where TSectionType : ConfigurationSection
//        {
//            try
//            {
//                Configuration fileConfiguration = ConfigurationManager.OpenExeConfiguration(exePath);
//                TSectionType savedExpressions = (TSectionType)fileConfiguration.GetSection(SavedExpressionsSectionName);

//                if (savedExpressions == null)
//                    throw new Exception(string.Format("Failed to get SavedExpressions sections from {0}", exePath));

//                return savedExpressions;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Error trying to load configuration file for " + exePath, ex);
//            }
//        }

//        /// <summary>
//        /// Gets the SavedExpressions section.
//        /// </summary>
//        /// <returns></returns>
//        public static TSectionType GetSystemsSection<TSectionType>()
//            where TSectionType : ConfigurationSection
//        {
//            return GetSavedExpressionsSection(GetExePath());
//        }

//        /// <summary>
//        /// Gets the Saved Configurations.
//        /// </summary>
//        /// <param name="exePath">The exe path.</param>
//        /// <returns></returns>
//        public static TCollectionType GetSavedExpressions(string exePath)
//        {
//            return GetSavedExpressionsSection(exePath).SavedExpressions;
//        }

//        /// <summary>
//        /// Gets the systems.
//        /// </summary>
//        /// <returns></returns>
//        public static TCollectionType GetSavedExpressions()
//        {
//            return GetSavedExpressions(GetExePath());
//        }

//        /// <summary>
//        /// Gets the systems.
//        /// </summary>
//        /// <value>The systems.</value>
//        [ConfigurationProperty("", IsDefaultCollection = true)]
//        //[SystemsIdsValidator()]
//        public TCollectionType SavedExpressions
//        {
//            get
//            {
//                return (TCollectionType)base[""];
//            }
//        }
//    }
//}
