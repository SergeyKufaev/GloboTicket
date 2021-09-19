using System.Collections.Generic;
using MediatR;

namespace GloboTicket.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
