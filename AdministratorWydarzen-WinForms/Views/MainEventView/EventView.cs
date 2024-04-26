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

        //Placeholder logic:
        private void SearchByTextBoxEnter(object sender, EventArgs e)
        {
            if (SearchByTextBox.ForeColor == Color.LightGray)
            {
                SearchByTextBox.Text = string.Empty;
                SearchByTextBox.ForeColor = Color.Black;
            }
        }

        private void SearchByTextBoxLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchByTextBox.Text.Trim()))
            {
                SearchByTextBox.Text = "Szukaj...";
                SearchByTextBox.ForeColor = Color.LightGray;
            }
            SearchByTextBox.Text = SearchByTextBox.Text.Trim();
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
    }
}
