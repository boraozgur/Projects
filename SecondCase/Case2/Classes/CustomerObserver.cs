using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case2.Classes;

namespace Case2.Classes
{
    /// <summary>
    /// ConcreteObserver - Gerçek takip eden nesnemiz.
    /// </summary>
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Takip ettiğim ürünün stoğu değişti.");
            Console.ReadLine();
        }
    }
}
