using AdministratorWydarzen_WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models.Dtos
{
    public class BasicEventDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int EventTypeId { get; set; }

        public override string ToString()
        {
            string eventTypeString = MapFromEventTypeId(EventTypeId);
            return $"{Title}; {StartDate}; {eventTypeString}";
        }

        private static string MapFromEventTypeId(int eventTypeId)
        {
            return eventTypeId switch
            {
                0 => "W pracy",
                1 => "Rodzinne",
                2 => "Rozrywka",
                3 => "Zdrowie",
                4 => "Sport",
                _ => string.Empty
            };
        }
    }


}
