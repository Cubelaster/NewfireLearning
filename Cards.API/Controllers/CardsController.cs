using Cards.API.Models;
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
        public async Task<Card> GetCard([FromRoute] Query query)
        {
            return await mediator.Send(query);
        }

        [HttpPost("/api/boards/{boardId}/cards")]
        [HttpPost("/api/cards")]
        public async Task<Card> CreateCard([FromRoute] int boardId, [FromBody] CreateCardCommand command)
        {
            command.BoardId = boardId;
            return await mediator.Send(command);
        }

        public class Query : IRequest<Card>
        {
            public int Id { get; set; }
        }

        public class CreateCardCommand : IRequest<Card>
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public bool IsComplete { get; set; }
            public int BoardId { get; set; }
        }
        public class GetCardHandler : IRequestHandler<Query,Card>
        {
            private Data.CardsContext context;

            public GetCardHandler(Data.CardsContext context)
            {
                this.context = context;
            }

            public async Task<Card> Handle(Query request, CancellationToken cancellationToken)
            {
                return await context.Cards.FindAsync(request.Id);
            }
                        
        }
        public class CreateCardHandler : IRequestHandler<CreateCardCommand,Card>
        {
            private Data.CardsContext context;

            public CreateCardHandler(Data.CardsContext context)
            {
                this.context = context;
            }

            public async Task<Card> Handle(CreateCardCommand request, CancellationToken cancellationToken)
            {
                var card = new Card
                {
                    Name = request.Name,
                    Description = request.Description,
                    DueDate = request.DueDate,
                    IsComplete = request.IsComplete,
                    BoardId = request.BoardId
                };
                context.Cards.Add(card);
                await context.SaveChangesAsync();
                return card;
            }
        }
    }
}
