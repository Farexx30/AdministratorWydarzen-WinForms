using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AdministratorWydarzen_WinForms.Configurations;
using AdministratorWydarzen_WinForms.Dtos;
using AdministratorWydarzen_WinForms.Models;
using AutoMapper;

namespace AdministratorWydarzen_WinForms.Presenters
{
    public interface IEventPresenter
    {
        public IEventView View { get; }
    }

    public class EventPresenter : IEventPresenter
    {
        private readonly IEventCsvReader _csvReader;
        private readonly IEventCsvWriter _csvWriter;
        private readonly IMapper _mapper;
        private readonly IEventData _eventData;

        private readonly BindingSource _eventsDtoBindingSource = [];

        public IEventView View { get; }

        public EventPresenter(IEventView view, IMapper mapper, IEventCsvReader csvReader, IEventCsvWriter csvWriter, IEventData eventData)
        {   
            View = view;
            _mapper = mapper;
            _csvReader = csvReader;
            _csvWriter = csvWriter;
            _eventData = eventData;
          
            View.MainEventViewOnLoadEvent += MainEventViewOnLoadEventHandler;
            View.MainEventViewOnClosedEvent += MainEventViewOnClosedEventHandler;
            View.AddEventClick += AddEventClickHandler;
            View.DeleteEventClick += DeleteEventClickHandler;
            View.SelectedEventChangedClick += SelectedEventChangedClickHandler;
            View.EventFiltersChanged += EventFiltersChangedHandler;
            View.EventSortDataChanged += EventSortDataChangedHandler;

            BindDataWithView();
        }

        private void BindDataWithView() => View.BindDataWithPresenter(_eventsDtoBindingSource);

        private void MainEventViewOnLoadEventHandler(object? sender, EventArgs e)
        {
            _eventData.AllEvents = _csvReader.ReadEvents();
            _eventsDtoBindingSource.DataSource = _mapper.Map<List<BasicEventDto>>(_eventData.AllEvents);
            EventSortDataChangedHandler(this, new SortDataEventDto());
        }

        private void MainEventViewOnClosedEventHandler(object? sender, EventArgs e)
        {
            _csvWriter.WriteEvents(_eventData.AllEvents);
        }

        private void AddEventClickHandler(object? sender, DetailedEventDto detailedEventDto)
        {
            detailedEventDto.Id = ++AppManager.NumberOfEventsCreated;

            var newEvent = _mapper.Map<Event>(detailedEventDto);
            _eventData.AllEvents?.Add(newEvent);

            var basicEventDto = _mapper.Map<BasicEventDto>(newEvent);
            _eventsDtoBindingSource.Add(basicEventDto);
        }

        private void DeleteEventClickHandler(object? sender, int index)
        {
            var clickedBasicEventDto = (BasicEventDto)_eventsDtoBindingSource[index];

            var eventToDelete = _eventData.AllEvents
                !.FirstOrDefault(e => e.Id == clickedBasicEventDto.Id);

            _eventData.AllEvents!.Remove(eventToDelete!);
            _eventsDtoBindingSource.Remove(clickedBasicEventDto);
        }

        private void SelectedEventChangedClickHandler(object? sender, int index)
        {
            var clickedBasicEventDto = (BasicEventDto)_eventsDtoBindingSource[index];

            var eventToDisplayDetails = _eventData.AllEvents
                !.FirstOrDefault(e => e.Id == clickedBasicEventDto.Id);

            var detailedEventDto = _mapper.Map<DetailedEventDto>(eventToDisplayDetails);

            View.DisplayClickedEventDetails(detailedEventDto);
        }

        //Filters/Sorts handlers:
        private void EventFiltersChangedHandler(object? sender, FiltersEventDto filters)
        {
            var eventsToDisplay = _eventData.FilterEvents(filters);

            var eventsToDisplayDtos = _mapper.Map<List<BasicEventDto>>(eventsToDisplay);

            _eventsDtoBindingSource.DataSource = eventsToDisplayDtos;
        }

        private void EventSortDataChangedHandler(object? sender, SortDataEventDto sortData)
        {
            var sortedEvents = _eventData.SortEvents((List<BasicEventDto>)_eventsDtoBindingSource.DataSource, sortData);

            _eventsDtoBindingSource.DataSource = sortedEvents;
        }
    }
}
