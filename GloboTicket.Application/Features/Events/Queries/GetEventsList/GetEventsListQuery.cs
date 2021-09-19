using System.Collections.Generic;
using MediatR;

namespace GloboTicket.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
