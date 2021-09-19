using System;
using System.Threading.Tasks;
using GloboTicket.Domain.Entities;

namespace GloboTicket.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
