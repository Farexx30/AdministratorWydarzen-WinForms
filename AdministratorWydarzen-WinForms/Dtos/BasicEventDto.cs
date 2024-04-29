using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Dtos
{
    public class BasicEventDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int EventTypeId { get; set; }
        public int EventPriorityId { get; set; }

        public override string ToString()
        {
            string eventTypeString = MapFromEventTypeId(EventTypeId);
            string eventPriorityString = MapFromEventPriorityId(EventPriorityId);
            return $"{Title}; {StartDate:dd.MM.yyyy-HH:mm}; {eventTypeString}; {eventPriorityString}";
        }

        private static string MapFromEventTypeId(int eventTypeId)
        {
            return eventTypeId switch
            {
                0 => "Praca",
                1 => "Rodzina",
                2 => "Rozrywka",
                3 => "Sport",
                4 => "Zdrowie",
                _ => string.Empty
            };
        }

        private static string MapFromEventPriorityId(int eventPriorityId)
        {
            return eventPriorityId switch
            {
                0 => "Niski",
                1 => "Średni",
                2 => "Wysoki",
                _ => string.Empty
            };
        }
    }


}
