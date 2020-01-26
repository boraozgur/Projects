using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCase.Classes
{
    abstract class Event
    {
        public int Priority;


        protected Event(int priority)
        {
            Priority = priority;
        }

        public abstract void Update(int alertIndex);
    }
}
