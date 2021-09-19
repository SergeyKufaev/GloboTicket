using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.Application.Contracts.Persistence;
using GloboTicket.Application.Features.Categories.Commands.CreateCategory;
using GloboTicket.Application.Profiles;
using GloboTicket.Application.UnitTests.Mocks;
using GloboTicket.Domain.Entities;
using Moq;
using Shouldly;
using Xunit;

namespace GloboTicket.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mockCategoryRepository.Object, _mapper);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(5);
        }
    }
}
