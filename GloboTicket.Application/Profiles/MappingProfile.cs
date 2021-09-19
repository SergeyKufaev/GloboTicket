using AutoMapper;
using GloboTicket.Application.Features.Categories.Commands.CreateCategory;
using GloboTicket.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.Application.Features.Events.Commands.UpdateEvent;
using GloboTicket.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.Application.Features.Events.Queries.GetEventsList;
using GloboTicket.Application.Features.Orders.Queries.GetOrdersForMonth;
using GloboTicket.Domain.Entities;

namespace GloboTicket.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
