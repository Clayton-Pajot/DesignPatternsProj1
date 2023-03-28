using Assi1.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Abstracts
{
    public interface IStrategy
    {
        public float EvaluateStack(ObjectDictionary<int, HeavyObject> list);
    }
}
