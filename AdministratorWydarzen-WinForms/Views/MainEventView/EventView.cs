using AdministratorWydarzen_WinForms.Views.MainView;

namespace AdministratorWydarzen_WinForms
{
    public interface IEventView
    {

    }

    public partial class EventView : Form, IEventView
    {
        public EventView()
        {
            InitializeComponent();
        }                                                                                                                         

        //Errors while creating event logic:
        private bool CheckAllPossibleErrors()
        {
            return !TitleTextBox.SetErrorIfEmptyTextBox(EventCreatorErrorProvider)
                & !DescriptionTextBox.SetErrorIfEmptyTextBox(EventCreatorErrorProvider)
                & !EventDateDateTimePicker.SetErrorIfBadStartDate(EventCreatorErrorProvider);
        }

        //Test:
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            if (CheckAllPossibleErrors())
            {
                MessageBox.Show("OK!");
            }
        }

        private void FilterByDateCheckBoxMouseHover(object sender, EventArgs e)
        {
            FilterByDateToolTip.SetToolTip(FilterByDateCheckBox, "Zaznacz, aby uwzglêdniæ datê");
        }

        private void FilterByDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterByDateDateTimePicker.Enabled ^= true;
        }
    }
}
