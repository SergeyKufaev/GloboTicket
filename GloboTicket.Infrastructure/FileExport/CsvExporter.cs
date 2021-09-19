using System.Collections.Generic;
using System.IO;
using CsvHelper;
using GloboTicket.Application.Contracts.Infrastructure;
using GloboTicket.Application.Features.Events.Queries.GetEventsExport;

namespace GloboTicket.Infrastructure
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.CurrentCulture);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
