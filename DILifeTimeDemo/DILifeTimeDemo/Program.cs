#region register the  services  [configureServices]


using DILifeTimeDemo.Interfaces;
using DILifeTimeDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddSingleton<ISingletonOperation, OperationService>(); //instancePerLifetime
builder.Services.AddScoped<IScopedOperation, OperationService>();   // instancePerRequest
builder.Services.AddTransient<ITrasitiveOperation, OperationService>(); //istancePerDependency


var app = builder.Build();
#endregion

#region middleware [configure]


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


#endregion