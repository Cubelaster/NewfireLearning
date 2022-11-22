using Cards.Api;

var app = WebApplication
    .CreateBuilder(args)
    .BuildEnvironment(args)
    .ConfigureServices()
    .Build()
    .ConfigurePipeline();

app.Run();
