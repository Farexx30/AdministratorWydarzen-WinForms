using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Configurations
{
    //Class for managing ids assignments: 
    public static class AppManager
    {
        private readonly static string _dataDirectory = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        private readonly static string _filePath = $@"{_dataDirectory}\Data\NumberOfEventsCreated.txt";
        public static int NumberOfEventsCreated { get; set; }

        public static void ReadNumberOfEventsCreated()
        {
            if (!File.Exists(_filePath))
            {
                MessageBox.Show($"Nie odnaleziono niezbędnego pliku \"{_filePath}\" przez co aplikacja nie może działać poprawnie");
                Environment.Exit(1);
            }
            else
            {
                NumberOfEventsCreated = int.Parse(File.ReadAllText(_filePath));
            }
        }

        public static void SaveNumberOfEventsCreated()
        {
            File.WriteAllText(_filePath, NumberOfEventsCreated.ToString());
        }
    }
}
