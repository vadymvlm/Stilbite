var appBuilder = WebApplication.CreateBuilder(args);
var app = appBuilder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();