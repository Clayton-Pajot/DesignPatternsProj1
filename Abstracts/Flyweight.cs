using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Abstracts
{
    public class Flyweight
    {
        //this is the common 'shared' state
        string intrinsicState = "";

        public void SetIntrinsicState(string newState)
        {
            intrinsicState = newState;
        }
        public string GetIntrinsicState()
        {
            return intrinsicState;
        }

        //we treat the bold status as extrinsic state (the client will provide it when calling print)
        public virtual void Print(bool bold)
        {
            //default implementation
        }
    }
}
