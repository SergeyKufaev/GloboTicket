using GloboTicket.Application.Responses;

namespace GloboTicket.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {
        }

        public CreateCategoryDto Category { get; set; }
    }
}