using Tasks.Communication.Entities;
using Task = Tasks.Communication.Entities.Task;


namespace Tasks.Application.UseCases.Tasks.GetById;

public class GetByIdTaskUseCase
{
    public Task Execute(int id)
    {
        var index = ListOfTasks.Tasks.FindIndex(task => task.Id == id);

        var response = ListOfTasks.Tasks[index];

        return response;
    }
}
