using DataManager.Base;
using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Command;

public class GetAllGoodCommand : IRequest<Result<List<Good>>>
{
    public GetAllGoodCommand(int fieldId)
    {
        FieldId = fieldId;
    }

    public int FieldId { get; set; }
}
