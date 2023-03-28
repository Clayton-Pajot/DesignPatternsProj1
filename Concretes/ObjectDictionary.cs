using Assi1.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace Assi1.Concretes
{
    public class ObjectDictionary<Key, HeavyObject> : IAggregate<HeavyObject>
    {

        protected Dictionary<Key, HeavyObject> dict = new Dictionary<Key, HeavyObject>();
        public IIterator<HeavyObject> CreateIterator()
        {
            return new ObjectDictionaryIterator<Key, HeavyObject>(this);
        }
        public void Add(Key key, HeavyObject value)
        {
            dict.Add(key, value);
        }

        public HeavyObject At(int position)
        {
            return dict.ElementAt(position).Value;
        }

        public int Length()
        {
            return dict.Count;
        }


    }
}
