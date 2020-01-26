using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Classes2
{
    class EventProducer
    {
        private List<Event> _events = new List<Event>();

        public void Attach(Event eventt)
        {
            _events.Add(eventt);
        }

        public void Detach(Event eventt)
        {
            _events.Remove(eventt);
        }

        private void Notify(int alertIndex)
        {
            // Herhangi bir değişiklik olduğunda gözlemleyicilerimizin Update metotunu tetikleterek istenilen aksiyonu gerçekleştirebiliriz. Örneğin: Kullanıcılara e-posta atmak gibi düşünebilirsiniz.
            //_events.ForEach(o => { o.Update(alertIndex); });
            var ec = (EventConsumer)_events[alertIndex];
            ec.Update(alertIndex);
        }

        public void ReadEvent()
        {
            for (int i = 1; i < _events.Count-1; i++)
            {
                if (_events[i-1].Priority == _events[i].Priority && _events[i].Priority == _events[i+1].Priority)
                {
                    this.Notify(i);


                    i = i + 2;

                    if (i >= _events.Count - 1)
                        return;

                }
            }


            //... stok değiştirilme işlemleri
            // Stok değiştirildiğinde gözlemcilerimize bildiriyoruz.            
        }
    }
}
