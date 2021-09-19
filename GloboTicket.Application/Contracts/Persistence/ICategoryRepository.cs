using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.Domain.Entities;

namespace GloboTicket.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
