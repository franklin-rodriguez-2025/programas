
using Microsoft.OpenApi.Models;


//
// Kind of project:
// ASP.NET Core Web App (Model-View-Controller) + API
// dotnet new mvc -n WebAspNetCoreMvc -f net9.0
// fullstack project => WebApp And API 
//

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddControllers(); // **

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc(
        "v1.0.0", 
        new OpenApiInfo {
            Title = "WebApp And API - ASP.NET CORE MVC",
            Description = "WebApp And API With ASP.NET CORE MVC",
            Version = "Version 1.0.0"
        }
    );
});

// OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 9999999999930 days.
    // You may want to change this for production scenarios,
    // see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
if (app.Environment.IsDevelopment())
{

    // app.MapOpenApi(); // OPENAPI 

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApp And API With ASP.NET CORE MVC");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseRouting();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
).WithStaticAssets();
app.MapControllers(); // **

// Minimal API
app.MapGet("/isup", () => "WebApp Web ASP.NET CORE MVC: Is running !");

app.Run();
