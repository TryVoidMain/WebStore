var builder = WebApplication.CreateBuilder(args);

// ������ ���� ��������� ������� 


var app = builder.Build();

var greetings = app.Configuration["ServerGreetings"];
app.MapGet("/", () =>greetings);

app.Run();
