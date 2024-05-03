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

        //Bind data with View:
        private void BindDataWithView() => View.BindDataWithPresenter(_eventsDtoBindingSource);


        //OnLoad logic:
        private void MainEventViewOnLoadEventHandler(object? sender, EventArgs e)
        {
            AppManager.ReadNumberOfEventsCreated();

            _eventData.AllEvents = _csvReader.ReadEvents();
            _eventsDtoBindingSource.DataSource = _mapper.Map<List<BasicEventDto>>(_eventData.AllEvents);

            EventSortDataChangedHandler(this, new SortDataEventDto());
        }

        //OnClosed logic:
        private void MainEventViewOnClosedEventHandler(object? sender, EventArgs e)
        {
            _csvWriter.WriteEvents(_eventData.AllEvents);
            AppManager.SaveNumberOfEventsCreated();
        }


        //AddEvent handler:
        private void AddEventClickHandler(object? sender, DetailedEventDto detailedEventDto)
        {
            detailedEventDto.Id = ++AppManager.NumberOfEventsCreated;

            var newEvent = _mapper.Map<Event>(detailedEventDto);
            _eventData.AddEvent(newEvent);

            var basicEventDto = _mapper.Map<BasicEventDto>(newEvent);
            _eventsDtoBindingSource.Add(basicEventDto);
        }
            

        //DeleteEvent handler:
        private void DeleteEventClickHandler(object? sender, int index)
        {
            var clickedBasicEventDto = (BasicEventDto)_eventsDtoBindingSource[index];

            _eventData.DeleteEvent(clickedBasicEventDto.Id);

            _eventsDtoBindingSource.Remove(clickedBasicEventDto);
        }


        //SelectEvent handler:
        private void SelectedEventChangedClickHandler(object? sender, int index)
        {
            var clickedBasicEventDto = (BasicEventDto)_eventsDtoBindingSource[index];

            var eventToDisplayDetails = _eventData.AllEvents
                .First(e => e.Id == clickedBasicEventDto.Id);

            var detailedEventDto = _mapper.Map<DetailedEventDto>(eventToDisplayDetails);

            View.DisplayClickedEventDetails(detailedEventDto);
        }


        //Filters and sorts handlers:
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
