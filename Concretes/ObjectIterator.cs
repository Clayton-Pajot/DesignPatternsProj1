using Assi1.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Concretes
{
    public class ObjectIterator<HeavyObject> : IIterator<HeavyObject>
    {
        protected HeavyObjectList<HeavyObject> list;

        protected int index;
        public ObjectIterator(HeavyObjectList<HeavyObject> list)
        {
            this.list = list;
            index = 0;
        }
        public bool IsCompleted()
        {
            return index >= list.Length();
        }

        public HeavyObject First()
        {
            return list.At(0);
        }

        public void Next()
        {
            index++;
        }

        public HeavyObject CurrentItem()
        {
            return list.At(index);
        }

    }
}
