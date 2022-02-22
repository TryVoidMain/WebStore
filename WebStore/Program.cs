var builder = WebApplication.CreateBuilder(args);

// должны быть добавлены сервисы 


var app = builder.Build();

var greetings = app.Configuration["ServerGreetings"];
app.MapGet("/", () =>greetings);

app.Run();
