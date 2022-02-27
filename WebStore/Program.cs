var builder = WebApplication.CreateBuilder(args);

// должны быть добавлены сервисы 
builder.Services.AddControllersWithViews();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //Генерация ошибок в режиме разработки
}

app.UseStaticFiles(); //Проверка на запрос файлов из папки wwwroot, в случае выполнения - всё что ниже пропускается.


//Пример ошибки в приложении
app.MapGet("/throw", () =>
{
    throw new ApplicationException("Пример ошибки приложения");
});

app.UseRouting();

app.MapGet("/greetings", () => app.Configuration["ServerGreetings"]);

app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
