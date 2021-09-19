using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.Application.Contracts.Persistence;
using GloboTicket.Application.Exceptions;
using GloboTicket.Domain.Entities;
using MediatR;

namespace GloboTicket.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IAsyncRepository<Event> eventRepository,
                                         IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.EventId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(Event), request.EventId);
            }

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
