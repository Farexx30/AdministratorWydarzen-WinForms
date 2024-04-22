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
    }
}
