using GoalSetter.Domain.Features.Clients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace GoalSetter.Api.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientsController
    {
        private readonly IMediator _mediator;

        public ClientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{clientId}", Name = "GetClientByIdRoute")]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(GetClientById.Response), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<GetClientById.Response>> GetById([FromRoute]GetClientById.Request request)
        {
            var response = await _mediator.Send(request);

            if (response.Client == null)
            {
                return new NotFoundObjectResult(request.ClientId);
            }

            return response;
        }

        [HttpGet(Name = "GetClientsRoute")]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(GetClients.Response), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetClients.Response>> Get()
            => await _mediator.Send(new GetClients.Request());           
    }
}
