using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCase.Classes
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
            var eventConsumer = (EventConsumer)_events[alertIndex];
            eventConsumer.Update(alertIndex);
        }

        public void ReadEvent()
        {
            for (int i = 1; i < _events.Count - 1; i++)
            {
                if (_events[i - 1].Priority == _events[i].Priority && _events[i].Priority == _events[i + 1].Priority)
                {
                    this.Notify(i);

                    i = i + 2;

                    if (i >= _events.Count - 1)
                        return;

                }
            }          
        }
    }
}
