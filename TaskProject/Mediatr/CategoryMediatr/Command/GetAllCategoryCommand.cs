using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TestMediatorApi.Mediatr.CategoryMediatr.Command;

public class GetAllCategoryCommand : IRequest<Result<List<Category>>>
{
    public GetAllCategoryCommand() { }
}