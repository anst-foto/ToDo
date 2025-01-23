using ToDo.BL;
using ToDo.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

var service = new TaskService();

app.MapGet("/tasks", () => service.GetAllTasks());
app.MapGet("/tasks/{id:int}", (int id) => service.GetTaskById(id));
app.MapPost("/tasks", (TaskDto task) => service.CreateTask(task));
app.MapPut("/tasks", (TaskDto task) => service.UpdateTask(task));
app.MapDelete("/tasks/{id:int}", (int id) => service.DeleteTask(id));

app.Run();