using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//endpoints - funcionalides 

//request / requisição - URL e 
// Método HTTP 
// parâmetro opcional

// GET - pegar alguma informação 
// POST - enviar alguma informação
app.MapGet("/", () => "ce vai paga, ce vai paga!");

app.MapGet("/testarurl", () => "Primeira API");

app.MapGet("/parametro/{param1}", 
    ([FromRoute] string param1) =>
{
    string result = param1 + "" + DateTime.Now;
    return "texto rápido";
});

app.Run();
