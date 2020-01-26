using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case2.Classes;
using Case2.Classes2;


namespace Case2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product();

            //// İlgili gözlemleyicimizi product nesnemize ekliyoruz ki değişim sonrasında notify edebilelim.
            //product.Attach(new CustomerObserver());

            //// Ürün stoğunu değiştiriyoruz.
            //product.ChangeStock();


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

