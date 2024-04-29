using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Dtos
{
    public class DetailedEventDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int EventTypeId { get; set; }
        public int EventPriorityId { get; set; }

        public override string ToString()
        {
            string eventTypeString = MapFromEventTypeId(EventTypeId);
            string eventPriorityString = MapFromEventPriorityId(EventPriorityId);

            return $"Tytuł: {Title}{Environment.NewLine}" +
                $"Opis: {Description}{Environment.NewLine}" +
                $"Data i godzina rozpoczęcia: {StartDate:dd.MM.yyyy-HH:mm}{Environment.NewLine}" +
                $"Typ wydarzenia: {eventTypeString}{Environment.NewLine}" +
                $"Priorytet wydarzenia: {eventPriorityString}";
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
