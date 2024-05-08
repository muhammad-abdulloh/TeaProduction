using MediatR;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Commands
{
    public class UpdateTeaCommand : IRequest<ResponseModel>
    {
        public int Id { get; set; }
        public string TeaName { get; set; }
        public string TeaType { get; set; }
        public string ProductionCountry { get; set; }
        public decimal TeaPrice { get; set; }
        public DateTimeOffset StartExpireDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset EndExpireDate { get; set; }

        public int MachineId { get; set; }
    }
}
