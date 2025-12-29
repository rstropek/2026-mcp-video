var builder = WebApplication.CreateBuilder(args);
builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello World!";
});

app.Run();

