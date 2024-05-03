using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdministratorWydarzen_WinForms.Models
{
    public interface IEventCsvReader
    {
        List<Event> ReadEvents();
    }

    public class EventCsvReader : IEventCsvReader
    {
        public List<Event> ReadEvents()
        {
            string dataDirectory = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
            string filePath = $@"{dataDirectory}\Data\Events.csv";
            var events = new List<Event>();

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Nie odnaleziono pliku \"{filePath}\"");
            }
            else
            {
                if (new FileInfo(filePath).Length != 0)
                {
                    var csvReaderConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("pl-PL"))
                    {
                        Delimiter = ";",
                    };

                    try
                    {
                        using var csvReader = new CsvReader(new StreamReader(filePath), csvReaderConfig);
                        events = csvReader.GetRecords<Event>().ToList();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show($"Nie można odczytać danych z pliku \"{filePath}\", gdyż jest on w tym momencie używany przez inny proces");
                    }                   
                }                
            }

            return events;
        }
    }
}
