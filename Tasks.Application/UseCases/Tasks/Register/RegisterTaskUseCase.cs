using Tasks.Communication.Entities;
using Tasks.Communication.Requests;
using Tasks.Communication.Responses;
using Task = Tasks.Communication.Entities.Task;

namespace Tasks.Application.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        var task = new Task
        {
            Id = ListOfTasks.Tasks.Count + 1,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DueDate = request.DueDate,
            Status = request.Status
        };

        ListOfTasks.Tasks.Add(task);

        return new ResponseRegisteredTaskJson
        {
            Id = task.Id,
            Name = task.Name
        };
    }
}
