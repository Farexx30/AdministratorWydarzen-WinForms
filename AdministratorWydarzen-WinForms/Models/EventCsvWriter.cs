using AdministratorWydarzen_WinForms.Configurations;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.Models
{
    public interface IEventCsvWriter
    {
        void WriteEvents(List<Event>? events);
    }

    public class EventCsvWriter : IEventCsvWriter
    {
        public void WriteEvents(List<Event>? events)
        {
            string dataDirectory = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
            string filePath = $@"{dataDirectory}\Data\Events.csv";

            var csvWriterConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("pl-PL"))
            {
                Delimiter = ";"
            };
            using var csvWriter = new CsvWriter(new StreamWriter(filePath), csvWriterConfig);
            csvWriter.WriteRecords(events);
        }
    }
}
