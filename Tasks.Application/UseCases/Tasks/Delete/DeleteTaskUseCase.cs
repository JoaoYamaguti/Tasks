using Tasks.Communication.Entities;

namespace Tasks.Application.UseCases.Tasks.Delete;

public class DeleteTaskUseCase
{
    public void Execute(int id)
    {
        var index = ListOfTasks.Tasks.FindIndex(t => t.Id == id);

        ListOfTasks.Tasks.Remove(ListOfTasks.Tasks[index]);
    }
}
