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
        List<Event>? ReadEvents();
    }

    public class EventCsvReader : IEventCsvReader
    {
        public List<Event>? ReadEvents()
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
                    var csvReaderConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("en-EN"))
                    {
                        Delimiter = ";",
                    };
                    using var csvReader = new CsvReader(new StreamReader(filePath), csvReaderConfig);
                    events = csvReader.GetRecords<Event>().ToList();
                }                
            }

            return events;
        }
    }
}
