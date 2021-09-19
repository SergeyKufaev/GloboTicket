using System.Collections.Generic;
using GloboTicket.Application.Features.Events.Queries.GetEventsExport;

namespace GloboTicket.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
