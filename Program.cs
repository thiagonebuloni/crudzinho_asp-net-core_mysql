using Microsoft.EntityFrameworkCore;
using WebMvcMysql.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContextPool<Contexto>
    (options => options.UseMySql(
        "server=localhost;port=3306;initial catalog=CRUD_MVC_MYSQL_AULA;uid=root;pwd=123",
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.25-mysql"), mySqlOptions =>
            mySqlOptions.EnableRetryOnFailure()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuarios}/{action=Index}/{id?}");

app.Run();
