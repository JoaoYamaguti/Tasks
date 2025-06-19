using Tasks.Communication.Entities;
using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = ListOfTasks.Tasks
        };
    }
}
