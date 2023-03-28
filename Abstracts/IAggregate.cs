using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Abstracts
{
    public interface IAggregate <out HeavyObject>
    {
        IIterator<HeavyObject> CreateIterator();
    }
}
