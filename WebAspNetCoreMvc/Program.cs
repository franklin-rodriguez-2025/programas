
    using Microsoft.EntityFrameworkCore;
    using Microsoft.OpenApi.Models;
    using WebAspNetCoreMvc.Contexto;
    using WebAspNetCoreMvc.Services;


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

    builder.Services.AddScoped<IUsuarioService, UsuarioService>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc(
            "v1",
            new OpenApiInfo {
                Title = "WebApp And API - ASP.NET CORE MVC",
                Description = "WebApp And API With ASP.NET CORE MVC",
                Version = "v1"
            }
        );
    });

    // OpenAPI at https://aka.ms/aspnet/openapi
    // builder.Services.AddOpenApi();


    // Leer cadena de conexión desde appsettings.json
    var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
    if( string.IsNullOrEmpty(connectionString))
    {
        throw new Exception("Connection string is null in appsettings.json");
    }


    /*
    //
    // Conexion MySQL con PomeloMySqlDriver
    // driver no actualizado aún ...
    //
    builder.Services.AddDbContext<OurDbContext>(
        options => {
            options.UseMySql(
                connectionString, 
                ServerVersion.AutoDetect(connectionString)
            );
        }
    );
    */

    // Registrar el DbContext con MySQL
    builder.Services.AddDbContext<OurDbContext>(
        options => options.UseMySQL(connectionString)
    );







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
