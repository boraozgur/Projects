using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Classes
{
    /// Observer - Soyut sınıfımız.
    /// Soyutlamamızın nedeni ise birden fazla sınıf tarafındanda takip edilmesini sağlamak.
    /// </summary>
    abstract class Observer
    {
        // Herhangi bir değişimde gözlemleyiciler tarafından yapılması istenilen aksiyonlar.
        public abstract void Update();
    }
}
