using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace GenericLogParser
{
    public abstract class ConfigurationElementCollectionBase<TElementType> : ConfigurationElementCollection
        where TElementType : ConfigurationElement, new()
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new TElementType();
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return GetElementKeyInternal(element);
        }

        protected abstract string GetElementKeyInternal(ConfigurationElement element);
        protected abstract override string ElementName { get; }

        public TElementType this[int index]
        {
            get
            {
                return (TElementType)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(TElementType element)
        {
            BaseAdd(element);
        }

        public void Remove(string key)
        {
            BaseRemove(key);
        }
    }
}
