using MediatR;
using TeaProduction.Application.Abstractions;
using TeaProduction.Application.UseCases.Teas.Commands;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Handlers.CommandHandlers
{
    public class CreateTeaCommandHandler : IRequestHandler<CreateTeaCommand, ResponseModel>
    {
        private readonly ITeaProductionDbContext _context;

        public CreateTeaCommandHandler(ITeaProductionDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateTeaCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var tea = new Tea
                {
                    TeaName = request.TeaName,
                    TeaType = request.TeaType,
                    ProductionCountry = request.ProductionCountry,
                    TeaPrice = request.TeaPrice,
                    StartExpireDate = request.StartExpireDate,
                    EndExpireDate = request.EndExpireDate,
                    MachineId = request.MachineId,
                };

                await _context.Teas.AddAsync(tea, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"{request.TeaName} Created",
                    IsSuccess = true,
                    StatusCode = 201
                };
            }

            return new ResponseModel
            {
                Message = $"{request.TeaName} Value Is Null or Empty",
                StatusCode = 400
            };
        }
    }
}
