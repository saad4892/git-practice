var builder = WebApplication.CreateBuilder(args);
// changes  for fecthc
//changes for push..
// Add services to the container.

// Added new feature for fetching data
Console.WriteLine("Hello from master branch!");
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
