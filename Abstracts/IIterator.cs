using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Abstracts
{
    public interface IIterator <out HeavyObject>
    {
        HeavyObject First();
        void Next();
        bool IsCompleted();

        HeavyObject CurrentItem();
    }
}
