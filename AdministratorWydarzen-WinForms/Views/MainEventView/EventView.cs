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
    //OGOLNIE DO ZROBIENIA JESZCZE: LOGIKA ODKLIKIWANIA EVENTU, dodaæ max ilosc znakow dla tytulu/opisu ORAZ POPRAWA WYWOLAN METOD ITD. BO DA SIE WIELE ULEPSZYC PEWNIE, NO I + ASYNC + to archiwum tez moze.
    public partial class EventView : Form, IEventView
    {
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

                var filters = GetFilters();
                EventFiltersChanged?.Invoke(this, filters);

                var sortData = GetSortData();
                EventSortDataChanged?.Invoke(this, sortData);
            }
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
        private void FiltersChangedEvent(object sender, EventArgs e)
        {
            var filters = GetFilters();
            EventFiltersChanged?.Invoke(this, filters);

            var sortData = GetSortData();
            EventSortDataChanged?.Invoke(this, sortData);

            EventDetailsTextBox.Text = string.Empty;
            AllEventsListBox.SelectedIndex = -1;
        }

        private void SortDataChangedEvent(object sender, EventArgs e)
        {
            var sortData = GetSortData();
            EventSortDataChanged?.Invoke(this, sortData);

            EventDetailsTextBox.Text = string.Empty;
            AllEventsListBox.SelectedIndex = -1;
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

        private Brush GetBrush(int index)
        {
            var drawingElement = (BasicEventDto)AllEventsListBox.Items[index];
            int eventTypeOfdrawingElement = drawingElement.EventTypeId;

            return eventTypeOfdrawingElement switch
            {
                0 => Brushes.BlueViolet,
                1 => Brushes.Green,
                2 => Brushes.Orange,
                3 => Brushes.Tan,
                4 => Brushes.YellowGreen,
                _ => null!,
            };
        }

        //UI logic connected with data filter: 
        private void FilterByDateCheckBoxMouseHover(object sender, EventArgs e)
        {
            FilterByDateToolTip.SetToolTip(FilterByDateCheckBox, "Zaznacz, aby uwzglêdniæ datê");
        }

        private void FilterByDateCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            FilterByDateDateTimePicker.Enabled ^= true;
            FiltersChangedEvent(sender, e);
        }
    }
}
