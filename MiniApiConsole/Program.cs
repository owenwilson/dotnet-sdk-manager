var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// endpoint
app.MapGet("/", () => "Hello from my transformed API");

// get
app.MapGet("/hello/{name}", (string name) => $"Hi, {name}!");
//Console.WriteLine("Hello, World!");

app.Run();
