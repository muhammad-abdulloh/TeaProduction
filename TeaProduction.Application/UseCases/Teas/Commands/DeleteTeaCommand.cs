using MediatR;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Commands
{
    public class DeleteTeaCommand : IRequest<ResponseModel>
    {
        public int Id { get; set; }
    }
}
