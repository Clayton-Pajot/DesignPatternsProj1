using Assi1.Abstracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assi1.Concretes
{
    public class ObjectDictionaryIterator<Key, HeavyObject> : IIterator<HeavyObject>
    {
        protected ObjectDictionary<Key, HeavyObject> dict;
        protected int index;
        public ObjectDictionaryIterator(ObjectDictionary<Key, HeavyObject> dict)
        {
            this.dict = dict;
            index = 0;
        }

        public HeavyObject First()
        {
            return dict.At(0);
        }

        public void Next()
        {
            ++index;
        }

        public bool IsCompleted()
        {
            return index >= dict.Length();
        }

        public HeavyObject CurrentItem()
        {
            return dict.At(index);
        }
    }
}
