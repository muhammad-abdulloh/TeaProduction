using MediatR;
using Microsoft.EntityFrameworkCore;
using TeaProduction.Application.Abstractions;
using TeaProduction.Application.UseCases.Teas.Queries;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Handlers.QueryHandlers
{
    public class GetByIdTeaQueryHandler : IRequestHandler<GetByIdTeaQuery, Tea>
    {
        private readonly ITeaProductionDbContext _context;

        public GetByIdTeaQueryHandler(ITeaProductionDbContext context)
        {
            _context = context;
        }

        public async Task<Tea> Handle(GetByIdTeaQuery request, CancellationToken cancellationToken)
        {
            var tea = await _context.Teas.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (tea != null)
            {
                return tea;
            }

            return null;

        }
    }
}
