var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello galera!");

app.MapPost("login", (minimal_api.domain.dtos.LoginDTO _loginDTO) =>
{
    if (_loginDTO.Email == "adm@teste.com" && _loginDTO.Senha == "12345")
    {
        return Results.Ok("Login com sucesso!");
    }
    else
    {
        return Results.Unauthorized();
    }

});

app.Run();
