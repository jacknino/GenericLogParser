using System.Configuration;

namespace GenericLogParser.SavedExpressions
{
    public class SavedExpressionCollection : ConfigurationElementCollectionBase<SavedExpression>
    {
        ///// <summary>
        ///// create new element
        ///// </summary>
        ///// <returns></returns>
        //    protected override ConfigurationElement CreateNewElement()
        //    {
        //        return new SavedExpression();
        //    }

        //    /// <summary>
        //    /// get element key value
        //    /// </summary>
        //    /// <param name="element"></param>
        //    /// <returns></returns>
        //    protected override object GetElementKey(ConfigurationElement element)
        //    {
        //        return ((SavedExpression)element).Name;
        //    }

        protected override string GetElementKeyInternal(ConfigurationElement element)
        {
            return ((SavedExpression)element).Name;
        }

        //    /// <summary>
        //    /// collection type
        //    /// </summary>
        //    public override ConfigurationElementCollectionType CollectionType
        //    {
        //        get { return ConfigurationElementCollectionType.BasicMap; }
        //    }

        /// <summary>
        /// tag name of collection element
        /// </summary>
        protected override string ElementName
        {
            get { return "SavedExpression"; }
        }
    }
}
