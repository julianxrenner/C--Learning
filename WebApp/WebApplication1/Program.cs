var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/test", () => "Hello World!!");

app.MapGet("/greet", () => "Hello Person!");

app.Run();
