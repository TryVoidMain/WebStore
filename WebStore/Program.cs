var builder = WebApplication.CreateBuilder(args);

// должны быть добавлены сервисы 


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
