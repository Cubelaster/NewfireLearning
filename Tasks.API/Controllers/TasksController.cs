using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tasks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private IMediator mediator;

        public TasksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Tasks.API.Models.Tasks> GetTask([FromRoute] Query query)
        {
            return await mediator.Send(query);
        }

        public class Query : IRequest<Tasks.API.Models.Tasks>
        {
            public int Id { get; set; }
        }

        public class TasksHandler : IRequestHandler<Query,Tasks.API.Models.Tasks>
        {
            private Tasks.API.Data.TasksContext context;

            public TasksHandler(Tasks.API.Data.TasksContext context)
            {
                this.context = context;
            }

            public async Task<Tasks.API.Models.Tasks> Handle(Query request, CancellationToken cancellationToken)
            {
                return await context.Tasks.FindAsync(request.Id);
            }
        }
    }
}
