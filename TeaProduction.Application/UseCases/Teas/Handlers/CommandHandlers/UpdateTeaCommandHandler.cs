using MediatR;
using Microsoft.EntityFrameworkCore;
using TeaProduction.Application.Abstractions;
using TeaProduction.Application.UseCases.Teas.Commands;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Handlers.CommandHandlers
{
    public class UpdateTeaCommandHandler : IRequestHandler<UpdateTeaCommand, ResponseModel>
    {
        private readonly ITeaProductionDbContext _context;

        public UpdateTeaCommandHandler(ITeaProductionDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateTeaCommand request, CancellationToken cancellationToken)
        {
            var tea = await _context.Teas.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (tea is not null)
            {
                tea.ModifyDate = DateTimeOffset.UtcNow;
                tea.TeaName = request.TeaName;
                tea.TeaType = request.TeaType;
                tea.ProductionCountry = request.ProductionCountry;
                tea.StartExpireDate = request.StartExpireDate;
                tea.EndExpireDate = request.EndExpireDate;
                tea.MachineId = request.MachineId;

                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"{request.Id} Tea Updated",
                    IsSuccess = true,
                    StatusCode = 202
                };
            }

            return new ResponseModel
            {
                Message = $"{request.Id} tea will be is null",
                StatusCode = 400
            };
        }
    }
}
