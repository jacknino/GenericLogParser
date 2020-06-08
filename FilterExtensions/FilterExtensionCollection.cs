using System.Configuration;

namespace GenericLogParser.FilterExtensions
{
    public class FilterExtensionCollection : ConfigurationElementCollectionBase<FilterExtension>
    {
        //protected override ConfigurationElement CreateNewElement()
        //{
        //    return new FilterExtension();
        //}

        protected override string GetElementKeyInternal(ConfigurationElement element)
        {
            return ((FilterExtension)element).Description;
        }

        //public override ConfigurationElementCollectionType CollectionType
        //{
        //    get { return ConfigurationElementCollectionType.BasicMap; }
        //}

        protected override string ElementName
        {
            get { return "FilterExtension"; }
        }

        //public FilterExtension this[int index]
        //{
        //    get
        //    {
        //        return (FilterExtension)BaseGet(index);
        //    }
        //    set
        //    {
        //        if (BaseGet(index) != null)
        //        {
        //            BaseRemoveAt(index);
        //        }
        //        BaseAdd(index, value);
        //    }
        //}

        //public void Add(FilterExtension savedExpression)
        //{
        //    BaseAdd(savedExpression);
        //}

        //public void Remove(string name)
        //{
        //    BaseRemove(name);
        //}
    }
}
