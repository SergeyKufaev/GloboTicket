using MediatR;

namespace GloboTicket.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery : IRequest<EventExportFileVm>
    {
    }
}
