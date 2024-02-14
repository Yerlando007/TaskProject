using KDS.Primitives.FluentResult;
using MediatR;
using TestMediatorApi.Models.EF;

namespace TestMediatorApi.Mediatr.CategoryMediatr.Command;

public class GetAllCategoryCommand : IRequest<Result<List<Category>>>
{
    public GetAllCategoryCommand() { }
}
