using MinimalApi.infraestrutura.Db;
using MinimalApi.DTOs;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DbContexto>(options => {
    options.UseSql(
        builder.Configuraton.GetConnectionString("sql"),
        ServerVersion.AutoDetect(builder.Configuraton.GetConnectionString("sql"));
    );
});
var app = builder.Build();

app.MapGet("/", () => "Ola pessoa");

app.MapPost("/login", (LoginDTO loginDTO) =>{
    if{loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456"}
       return Results.Ok ("Login com sucesso");

    else
    
        return Results.Unauthorized{};
        
});    
       
app.Run();




