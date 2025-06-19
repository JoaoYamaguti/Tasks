using Tasks.Communication.Entities;
using Tasks.Communication.Requests;

namespace Tasks.Application.UseCases.Tasks.Update;

public class UpdateTaskUseCase
{
    public void Execute(int id, RequestTaskJson request)
    {
        var index = ListOfTasks.Tasks.FindIndex(task => task.Id == id);

        ListOfTasks.Tasks[index].Name = request.Name;
        ListOfTasks.Tasks[index].Description = request.Description;
        ListOfTasks.Tasks[index].Priority = request.Priority;
        ListOfTasks.Tasks[index].DueDate = request.DueDate;
        ListOfTasks.Tasks[index].Status = request.Status;
    }

}
