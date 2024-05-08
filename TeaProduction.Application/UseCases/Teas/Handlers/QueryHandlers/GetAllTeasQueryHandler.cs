using MediatR;
using Microsoft.EntityFrameworkCore;
using TeaProduction.Application.Abstractions;
using TeaProduction.Application.UseCases.Teas.Queries;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.UseCases.Teas.Handlers.QueryHandlers
{
    public class GetAllTeasQueryHandler : IRequestHandler<GetAllTeasQuery, IEnumerable<Tea>>
    {
        private readonly ITeaProductionDbContext _context;

        public GetAllTeasQueryHandler(ITeaProductionDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tea>> Handle(GetAllTeasQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Teas.ToListAsync();

            return result;
        }
    }
}
