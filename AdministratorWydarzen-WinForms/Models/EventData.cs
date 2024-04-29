using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models
{
    public interface IEventData
    {
        List<Event>? AllEvents { get; set; }
    }

    public class EventData : IEventData
    {
        public List<Event>? AllEvents { get; set; }
    }
}
