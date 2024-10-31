using GetConselho_Api.Services;
using GetConselho_Api.Services.Interface;
using GetConselho_Api.Services.Refit;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IConselhoService, ConselhoService>();
builder.Services.AddRefitClient<IConselhoServiceRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://api.adviceslip.com/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
