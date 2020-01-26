using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondCase.Classes;

namespace SecondCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventProducer = new EventProducer();

            var rnd = new Random();


            for (int i = 0; i < 400; i++)
            {
                eventProducer.Attach(new EventConsumer(rnd.Next(0, 3)));
            }

            eventProducer.ReadEvent();
            Console.ReadKey();
        }
    }
}
