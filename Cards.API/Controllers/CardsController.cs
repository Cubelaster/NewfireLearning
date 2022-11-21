using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private IMediator mediator;

        public CardsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Cards.API.Models.Card> GetTask([FromRoute] Query query)
        {
            return await mediator.Send(query);
        }

        public class Query : IRequest<Cards.API.Models.Card>
        {
            public int Id { get; set; }
        }

        public class CardHandler : IRequestHandler<Query,Cards.API.Models.Card>
        {
            private Cards.API.Data.CardsContext context;

            public CardHandler(Cards.API.Data.CardsContext context)
            {
                this.context = context;
            }

            public async Task<Cards.API.Models.Card> Handle(Query request, CancellationToken cancellationToken)
            {
                return await context.Cards.FindAsync(request.Id);
            }
        }
    }
}
