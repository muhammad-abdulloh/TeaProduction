using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeaProduction.Application.UseCases.Teas.Commands;
using TeaProduction.Application.UseCases.Teas.Queries;

namespace TeaProduction.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTea(CreateTeaCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTea(UpdateTeaCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTea(DeleteTeaCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeas()
        {
            var result = await _mediator.Send(new GetAllTeasQuery());

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdTea(int TeaId)
        {
            var result = await _mediator.Send(new GetByIdTeaQuery
            {
                Id = TeaId
            });
            return Ok(result);
        }

    }
}
