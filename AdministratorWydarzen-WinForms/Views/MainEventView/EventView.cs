using AdministratorWydarzen_WinForms.Dtos;
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
        event EventHandler<FiltersEventDto>? EventFiltersChanged;
        event EventHandler<SortDataEventDto>? EventSortDataChanged;
        void BindDataWithPresenter(BindingSource? eventsDto);
        void DisplayClickedEventDetails(DetailedEventDto detailedEventDto);
    }

    public partial class EventView : Form, IEventView
    {
        private int _lastClickedIndex = -2;

        public event EventHandler? MainEventViewOnLoadEvent;
        public event EventHandler? MainEventViewOnClosedEvent;
        public event EventHandler<DetailedEventDto>? AddEventClick;
        public event EventHandler<int>? DeleteEventClick;
        public event EventHandler<int>? SelectedEventChangedClick;
        public event EventHandler<FiltersEventDto>? EventFiltersChanged;
        public event EventHandler<SortDataEventDto>? EventSortDataChanged;

        public EventView()
        {
            InitializeComponent();
        }   
        
        //OnLoad event:
        private void MainEventViewOnLoad(object sender, EventArgs e)
        {
            MainEventViewOnLoadEvent?.Invoke(this, EventArgs.Empty);
            AllEventsListBox.SelectedIndex = -1;
        }


        //OnClosed event:
        private void MainEventViewOnClosed(object sender, EventArgs e)
        {
            MainEventViewOnClosedEvent?.Invoke(this, EventArgs.Empty);
        }


        //Bind data with presenter:
        public void BindDataWithPresenter(BindingSource? eventsDto) => AllEventsListBox.DataSource = eventsDto;


        //Errors logic while creating event:
        private bool CheckAllPossibleErrors()
        {
            return !TitleTextBox.SetErrorIfEmptyTextBox(EventCreatorErrorProvider)
                & !DescriptionTextBox.SetErrorIfEmptyTextBox(EventCreatorErrorProvider)
                & !EventDateDateTimePicker.SetErrorIfBadStartDate(EventCreatorErrorProvider);
        }


        //Click events:
        private void DeleteEventButtonClick(object sender, EventArgs e)
        {
            if (AllEventsListBox.SelectedIndex != -1)
            {
                DeleteEventClick?.Invoke(this, AllEventsListBox.SelectedIndex);

                AllEventsListBox.ClearSelected();
                EventDetailsTextBox.Clear();
                _lastClickedIndex = -2;
            }
        }

        private void AddEventButtonClick(object sender, EventArgs e)
        {
            if (CheckAllPossibleErrors())
            {
                var eventDto = GetDataFromBoxes();
                AddEventClick?.Invoke(this, eventDto);

                var filters = GetFilters();
                EventFiltersChanged?.Invoke(this, filters);
                var sortData = GetSortData();
                EventSortDataChanged?.Invoke(this, sortData);

                SetDefaultValuesToAllBoxes();
                AllEventsListBox.ClearSelected();
                EventDetailsTextBox.Clear();
                _lastClickedIndex = -2;
            }
        }

        private void AllEventsListBoxClick(object sender, EventArgs e)
        {
            if (_lastClickedIndex == AllEventsListBox.SelectedIndex)
            {
                AllEventsListBox.ClearSelected();
                EventDetailsTextBox.Clear();
                _lastClickedIndex = -2;
            }
            else if(AllEventsListBox.SelectedIndex != -1)
            {
                SelectedEventChangedClick?.Invoke(this, AllEventsListBox.SelectedIndex);

                _lastClickedIndex = AllEventsListBox.SelectedIndex;
            }
        }


        //Filters and sorts events:
        private void FiltersChangedEvent(object sender, EventArgs e)
        {
            var filters = GetFilters();
            EventFiltersChanged?.Invoke(this, filters);
            var sortData = GetSortData();
            EventSortDataChanged?.Invoke(this, sortData);

            EventDetailsTextBox.Clear();
            AllEventsListBox.SelectedIndex = -1;
            _lastClickedIndex = -2;
        }

        private void SortDataChangedEvent(object sender, EventArgs e)
        {
            var sortData = GetSortData();
            EventSortDataChanged?.Invoke(this, sortData);

            EventDetailsTextBox.Clear();
            AllEventsListBox.SelectedIndex = -1;
            _lastClickedIndex = -2;
        }
        

        //Creating Dto models:
        private FiltersEventDto GetFilters()
        {
            var filters = new FiltersEventDto()
            {
                FilterByDateValue = FilterByDateCheckBox.Checked ? DateOnly.Parse(FilterByDateDateTimePicker.Value.ToString("dd.MM.yyyy")) : null,
                FilterByTypeValueId = FilterByTypeComboBox.SelectedIndex > 0 ? FilterByTypeComboBox.SelectedIndex - 1 : null,
                FilterByPriorityValueId = FilterByPriorityComboBox.SelectedIndex > 0 ? FilterByPriorityComboBox.SelectedIndex - 1 : null
            };

            return filters;
        }

        private SortDataEventDto GetSortData()
        {
            var sortData = new SortDataEventDto()
            {
                SortByValueId = SortByComboxBox.SelectedIndex,
                SortDirection = (SortDirection)SortDirectionComboBox.SelectedIndex
            };

            return sortData;
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


        //Drawing items in ListBox:
        private void AllEventsListBoxDrawItems(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();

                var currentItemText = AllEventsListBox.Items[e.Index].ToString();
                var currentItemTextSize = e.Graphics.MeasureString(currentItemText, e.Font!);
                if (currentItemTextSize.Width > AllEventsListBox.HorizontalExtent)
                {
                    AllEventsListBox.HorizontalExtent = (int)currentItemTextSize.Width;
                }

                Brush brush = GetBrush(e.Index);

                e.Graphics.DrawString(currentItemText, e.Font!, brush, e.Bounds);
            }           
        }

        private Brush GetBrush(int index)
        {
            var currentElement = (BasicEventDto)AllEventsListBox.Items[index];
            int eventTypeOfcurrentElement = currentElement.EventTypeId;

            return eventTypeOfcurrentElement switch
            {
                0 => Brushes.BlueViolet,
                1 => Brushes.Maroon,
                2 => Brushes.Orange,
                3 => Brushes.Tan,
                4 => Brushes.YellowGreen,
                _ => null!,
            };
        }


        //Display event details:
        public void DisplayClickedEventDetails(DetailedEventDto detailedEventDto)
        {
            EventDetailsTextBox.Text = detailedEventDto.ToString();
        }


        //UI logic clearing all boxes:
        private void SetDefaultValuesToAllBoxes()
        {
            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
            EventDateDateTimePicker.Value = DateTime.Now;
            TypeComboBox.SelectedIndex = 0;
            PriorityComboBox.SelectedIndex = 0;
        }


        //UI logic connected with data filter: 
        private void FilterByDateCheckBoxMouseHover(object sender, EventArgs e)
        {
            FilterByDateToolTip.SetToolTip(FilterByDateCheckBox, "Zaznacz, aby uwzgl�dni� dat�");
        }

        private void FilterByDateCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            FilterByDateDateTimePicker.Enabled ^= true;
            FiltersChangedEvent(this, EventArgs.Empty);
        }
    }
}
