var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  //Enables Controllers

// ✅ Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  //Enable Swagger for API documentation

var app = builder.Build();

// ✅ Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();  //Connect controller to map

app.Run();