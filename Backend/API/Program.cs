
using Bussines.Dependencies.ContextDI;
using Bussines.Dependencies.DependencyDI;
using Bussines.Dependencies.IdentityDI;
using Bussines.Dependencies.MapperDI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddContexts(builder.Configuration);
builder.Services.AddIdentities();
builder.Services.DependencyManagers(builder.Configuration);
builder.Services.AddAutoMapper();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
