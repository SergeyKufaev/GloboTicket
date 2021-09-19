using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.Application.Contracts.Persistence;
using GloboTicket.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.Application.Profiles;
using GloboTicket.Application.UnitTests.Mocks;
using GloboTicket.Domain.Entities;
using Moq;
using Shouldly;
using Xunit;

namespace GloboTicket.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mockCategoryRepository.Object, _mapper);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
