using EjempliApi.Extensions;


var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

// Agregar configuración de secretos de usuario
builder.Configuration.AddUserSecrets<Program>();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var Cors = "Cors";

builder.Services.AddInjectionInfrastructure(Configuration);


if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors
        , builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();

        });
});


var app = builder.Build();
app.UseCors(Cors);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.Run();
