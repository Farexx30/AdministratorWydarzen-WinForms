using AdministratorWydarzen_WinForms.Models.Dtos;
using AdministratorWydarzen_WinForms.Views.MainView;
using System.ComponentModel;

namespace AdministratorWydarzen_WinForms
{
    public interface IEventView
    {
        event EventHandler? MainEventViewOnLoadEvent;
        event EventHandler? MainEventViewOnClosedEvent;
        event EventHandler<DetailedEventDto>? AddEventClick;
        void BindDataWithPresenter(BindingSource? eventsDto);
    }

    public partial class EventView : Form, IEventView
    {
        public event EventHandler? MainEventViewOnLoadEvent;
        public event EventHandler? MainEventViewOnClosedEvent;
        public event EventHandler<DetailedEventDto>? AddEventClick;

        public EventView()
        {
            InitializeComponent();
        }   
        
        private void MainEventViewOnLoad(object sender, EventArgs e)
        {
            MainEventViewOnLoadEvent?.Invoke(this, EventArgs.Empty);
        }

        private void MainEventViewOnClosed(object sender, EventArgs e)
        {
            MainEventViewOnClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void BindDataWithPresenter(BindingSource? eventsDto) => AllEventsListBox.DataSource = eventsDto;

        //Errors while creating event logic:
        private bool CheckAllPossibleErrors()
        {
            return !TitleTextBox.SetErrorIfEmptyTextBox(EventCreatorErrorProvider)
                & !DescriptionTextBox.SetErrorIfEmptyTextBox(EventCreatorErrorProvider)
                & !EventDateDateTimePicker.SetErrorIfBadStartDate(EventCreatorErrorProvider);
        }

        
        private void AddEventButtonClick(object sender, EventArgs e)
        {
            if (CheckAllPossibleErrors())
            {
                var eventDto = GetDataFromBoxes();
                AddEventClick?.Invoke(this, eventDto);
            }
        }

        private DetailedEventDto GetDataFromBoxes()
        {
            var eventDto = new DetailedEventDto()
            {
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                StartDate = EventDateDateTimePicker.Value,
                EventTypeId = TypeComboBox.SelectedIndex,
                EventPriorityId = PriorityComboBox.SelectedIndex
            };

            return eventDto;
        }


        //UI logic connected with data filter: 
        private void FilterByDateCheckBoxMouseHover(object sender, EventArgs e)
        {
            FilterByDateToolTip.SetToolTip(FilterByDateCheckBox, "Zaznacz, aby uwzglêdniæ datê");
        }

        private void FilterByDateCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            FilterByDateDateTimePicker.Enabled ^= true;
        }
    }
}
