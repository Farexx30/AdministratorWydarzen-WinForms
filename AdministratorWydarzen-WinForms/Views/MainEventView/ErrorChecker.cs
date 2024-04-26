using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Views.MainView
{
    public static class ErrorChecker
    {
        public static bool SetErrorIfEmptyTextBox(this TextBox textBox, ErrorProvider EventCreatorErrorProvider)
        {
            textBox.Text = textBox.Text.Trim();
            if (string.IsNullOrEmpty(textBox.Text))
            {
                EventCreatorErrorProvider.SetError(textBox, "To pole nie może być puste");
                EventCreatorErrorProvider.SetIconAlignment(textBox, ErrorIconAlignment.TopRight);
                return true;
            }

            EventCreatorErrorProvider.SetError(textBox, string.Empty);
            return false;
        }

        public static bool SetErrorIfBadStartDate(this DateTimePicker EventDateDateTimePicker, ErrorProvider EventCreatorErrorProvider)
        {
            if (EventDateDateTimePicker.Value < DateTime.Now)
            {
                EventCreatorErrorProvider.SetError(EventDateDateTimePicker, "Niepoprawna data rozpoczęcia wydarzenia");
                EventCreatorErrorProvider.SetIconAlignment(EventDateDateTimePicker, ErrorIconAlignment.TopRight);
                return true;
            }

            EventCreatorErrorProvider.SetError(EventDateDateTimePicker, string.Empty);
            return false;
        }
    }
}
