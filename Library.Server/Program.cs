using Library.Server.Configurations;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.CorsRegister();
builder.Services.DataBaseRegister(builder.Configuration);
builder.Services.ServicesRegister();
builder.Services.IdentityRegister(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.SwaggerRegister();

var app = builder.Build();

app.SwaggereConfigure();
app.CorsConfigure();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
