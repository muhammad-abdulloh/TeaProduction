using MediatR;
using Microsoft.EntityFrameworkCore;
using TeaProduction.Application.Abstractions;
using TeaProduction.Application.UseCases.Teas.Commands;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Handlers.CommandHandlers
{
    public class DeleteTeaCommandHandler : IRequestHandler<DeleteTeaCommand, ResponseModel>
    {
        private readonly ITeaProductionDbContext _context;

        public DeleteTeaCommandHandler(ITeaProductionDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteTeaCommand request, CancellationToken cancellationToken)
        {
            var tea = await _context.Teas.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (tea != null)
            {
                tea.DeletedDate = DateTimeOffset.UtcNow;
                tea.IsDeleted = true;

                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Message = $"{request.Id} tea is deleted",
                    IsSuccess = true,
                    StatusCode = 203
                };
            }

            return new ResponseModel
            {
                Message = $"{request.Id} tea not fount",
                StatusCode = 404
            };
        }
    }
}
