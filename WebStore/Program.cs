var builder = WebApplication.CreateBuilder(args);

// ������ ���� ��������� ������� 
builder.Services.AddControllersWithViews();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //��������� ������ � ������ ����������
}

app.UseStaticFiles(); //�������� �� ������ ������ �� ����� wwwroot, � ������ ���������� - �� ��� ���� ������������.


//������ ������ � ����������
app.MapGet("/throw", () =>
{
    throw new ApplicationException("������ ������ ����������");
});

app.UseRouting();

app.MapGet("/greetings", () => app.Configuration["ServerGreetings"]);

app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
