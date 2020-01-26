using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCase.Classes
{
    class EventConsumer : Event
    {
        public EventConsumer(int priority) : base(priority)
        {
            Priority = priority;
        }


        public override void Update(int alertIndex)
        {
            Console.WriteLine($"Alert index number {alertIndex} priority {Priority}");
        }
    }
}
