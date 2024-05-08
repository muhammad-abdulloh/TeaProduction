using MediatR;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Queries
{
    public class GetAllTeasQuery : IRequest<IEnumerable<Tea>>
    {
    }
}
