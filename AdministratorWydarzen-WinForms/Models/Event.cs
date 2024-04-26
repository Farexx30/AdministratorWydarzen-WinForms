using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models
{
    public class Event
    {
        public int Id { get; set; } 
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public EventType EventType { get; set; } = EventType.Entertainment;
        public EventPriority EventPriority { get; set; } = EventPriority.LowPriority;
    }

    public enum EventType
    {
        Work,
        Family,
        Entertainment,
        Health,
        Sport
    }

    public enum EventPriority
    {
        LowPriority,
        MediumPriority,
        HighPriority
    }
}
