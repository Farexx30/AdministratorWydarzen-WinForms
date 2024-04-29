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
        event EventHandler<int>? DeleteEventClick;
        event EventHandler<int>? SelectedEventChangedClick;
        void BindDataWithPresenter(BindingSource? eventsDto);
        void DisplayClickedEventDetails(DetailedEventDto detailedEventDto);
    }

    public partial class EventView : Form, IEventView
    {
        public event EventHandler? MainEventViewOnLoadEvent;
        public event EventHandler? MainEventViewOnClosedEvent;
        public event EventHandler<DetailedEventDto>? AddEventClick;
        public event EventHandler<int>? DeleteEventClick;
        public event EventHandler<int>? SelectedEventChangedClick;

        public EventView()
        {
            InitializeComponent();
        }   
        
        private void MainEventViewOnLoad(object sender, EventArgs e)
        {
            MainEventViewOnLoadEvent?.Invoke(this, EventArgs.Empty);
            AllEventsListBox.SelectedIndex = -1;
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

        //Clicks:
        private void DeleteEventButtonClick(object sender, EventArgs e)
        {
            if(AllEventsListBox.SelectedIndex != -1)
            {
                DeleteEventClick?.Invoke(this, AllEventsListBox.SelectedIndex);
                EventDetailsTextBox.Text = string.Empty;
            }
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

        private void AllEventsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if(AllEventsListBox.SelectedIndex != -1)
            {
                SelectedEventChangedClick?.Invoke(this, AllEventsListBox.SelectedIndex);
            }
        }

        public void DisplayClickedEventDetails(DetailedEventDto detailedEventDto)
        {
            EventDetailsTextBox.Text = detailedEventDto.ToString();
        }


        //Filters/sorts:
        private void FilterByDateDateTimePickerValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void FilterByTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }

        private void FilterByPriorityComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("3");
        }

        private void SortByComboxBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("4");
        }

        private void SortDirectionComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("5");
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
