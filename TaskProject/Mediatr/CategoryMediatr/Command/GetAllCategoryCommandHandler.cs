using KDS.Primitives.FluentResult;
using MediatR;
using TestMediatorApi.Interfaces;
using TestMediatorApi.Models.EF;

namespace TestMediatorApi.Mediatr.CategoryMediatr.Command;

public class GetAllCategoryCommandHandler : IRequestHandler<GetAllCategoryCommand, Result<List<Category>>>
{
    private readonly ICategoryAdd _category;
    public GetAllCategoryCommandHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }
    public async Task<Result<List<Category>>> Handle(GetAllCategoryCommand request, CancellationToken cancellationToken)
    {
        var item = await _category.GetFieldsCategory();
        return Result.Success(item);
    }
}
