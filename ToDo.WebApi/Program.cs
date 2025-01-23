var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/tasks", () => { });
app.MapGet("/tasks/{id}", () => { });
app.MapPost("/tasks", () => {});
app.MapPut("/tasks/{id}", () => {});
app.MapDelete("/tasks/{id}", () => {});

app.Run();