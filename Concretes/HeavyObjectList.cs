using Assi1.Abstracts;
using Assi1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Assi1.Concretes
{
    
    public class HeavyObjectList<HeavyObject> : IAggregate<HeavyObject>
    {
        protected List<HeavyObject> list = new List<HeavyObject>();
        ObjectDictionary<int, HeavyObject> dictionary = new ObjectDictionary<int, HeavyObject>();
        public IIterator<HeavyObject> CreateIterator()
        {
            return new ObjectIterator<HeavyObject>(this);
        }

        public void Add(HeavyObject obj)
        {
            list.Add(obj);
        }

        public int Length()
        {
            return list.Count;
        }
        public HeavyObject At(int position)
        {
            return list[position];
        }
        public void Print()
        {

            for (IIterator<HeavyObject> i = dictionary.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                //i.CurrentItem().Print();
            }
        }
    }
}
