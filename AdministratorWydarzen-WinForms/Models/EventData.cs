using AdministratorWydarzen_WinForms.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models
{
    public interface IEventData
    {
        List<Event> AllEvents { get; set; }
        List<Event> FilterEvents(FiltersEventDto filters);    
        List<BasicEventDto> SortEvents(List<BasicEventDto> displayedEvents, SortDataEventDto sortData);       
    }

    public class EventData : IEventData
    {
        public List<Event> AllEvents { get; set; } = [];

        public List<Event> FilterEvents(FiltersEventDto filters)
        {
            var eventsToDisplay = AllEvents
                !.Where(e => (filters.FilterByDateValue == null || DateOnly.Parse(e.StartDate.ToString("dd.MM.yyyy")) == filters.FilterByDateValue)
                && (filters.FilterByTypeValueId == null || (int)e.EventType == filters.FilterByTypeValueId)
                && (filters.FilterByPriorityValueId == null || (int)e.EventPriority == filters.FilterByPriorityValueId))
                .ToList();

            return eventsToDisplay;
        }

        public List<BasicEventDto> SortEvents(List<BasicEventDto> displayedEvents, SortDataEventDto sortData)
        {
            var columnsSelector = new Dictionary<int, Expression<Func<BasicEventDto, object>>>()
            {
                { 0, e => e.StartDate },
                { 1, e => e.EventTypeId },
                { 2, e => e.EventPriorityId },
            };

            var selectedColumn = columnsSelector[sortData.SortByValueId];

            displayedEvents = sortData.SortDirection == SortDirection.ASC
               ? displayedEvents.AsQueryable().OrderBy(selectedColumn).ToList()
               : displayedEvents.AsQueryable().OrderByDescending(selectedColumn).ToList();

            return displayedEvents;
        }
    }
}
