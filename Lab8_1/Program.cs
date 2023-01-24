var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", (HttpContext _http) =>
@"Name: Raman Vasko" + "\n" +
$"Date: {DateTime.Now}\n" +
$"Enviroment: {app.Environment.EnvironmentName}\n" +
$"ApplicationName: {app.Environment.ApplicationName}\n" +
$"Host: {_http.Request.Host.Value}\n" +
$"Protocol: {_http.Request.Protocol}\n"
);

app.Run();