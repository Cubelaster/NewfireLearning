using Workspaces.Api;

var app = WebApplication
    .CreateBuilder()
    .ConfigureServices()
    .Build()
    .ConfigurePipeline();

app.Run();
