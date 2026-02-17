using JPMorgan.Calculations;
using JPMorgan.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddScoped<IndexCalculator>();
builder.Services.AddScoped<ReturnsCalculator>();
builder.Services.AddScoped<VolatilityCalculator>();
builder.Services.AddScoped<MovingAverageCalculator>();
builder.Services.AddScoped<AnalyticsService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowReact");

app.MapControllers();

app.Run();
