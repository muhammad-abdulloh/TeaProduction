using MediatR;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Queries
{
    public class GetByIdTeaQuery : IRequest<Tea>
    {
        public int Id { get; set; }
    }
}
