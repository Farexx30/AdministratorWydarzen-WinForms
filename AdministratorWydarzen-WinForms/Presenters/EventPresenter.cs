using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministratorWydarzen_WinForms.Configurations;
using AdministratorWydarzen_WinForms.Models;
using AdministratorWydarzen_WinForms.Models.Dtos;
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

        private List<Event>? _allEvents = [];
        private readonly BindingSource _eventsDtoBindingSource = [];

        public IEventView View { get; }

        public EventPresenter(IEventView view, IEventCsvReader csvReader, IEventCsvWriter csvWriter, IMapper mapper)
        {   
            View = view;
            _mapper = mapper;
            _csvReader = csvReader;
            _csvWriter = csvWriter;
          
            View.MainEventViewOnLoadEvent += MainEventViewOnLoadEventHandler;
            View.MainEventViewOnClosedEvent += MainEventViewOnClosedEventHandler;
            View.AddEventClick += AddEventClickHandler;
            
            BindDataWithView();
        }

        private void BindDataWithView() => View.BindDataWithPresenter(_eventsDtoBindingSource);

        private void MainEventViewOnLoadEventHandler(object? sender, EventArgs e)
        {
            _allEvents = _csvReader.ReadEvents();
            _eventsDtoBindingSource.DataSource = _mapper.Map<List<BasicEventDto>>(_allEvents);
        }

        private void MainEventViewOnClosedEventHandler(object? sender, EventArgs e)
        {
            _csvWriter.WriteEvents(_allEvents);
        }

        private void AddEventClickHandler(object? sender, DetailedEventDto detailedEventDto)
        {
            detailedEventDto.Id = ++AppManager.NumberOfEventsCreated;

            var newEvent = _mapper.Map<Event>(detailedEventDto);
            _allEvents?.Add(newEvent);

            var basicEventDto = _mapper.Map<BasicEventDto>(newEvent);
            _eventsDtoBindingSource.Add(basicEventDto);
        }       
    }
}
