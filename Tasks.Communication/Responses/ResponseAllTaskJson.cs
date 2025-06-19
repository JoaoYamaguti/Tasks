using Task = Tasks.Communication.Entities.Task;

namespace Tasks.Communication.Responses;

public class ResponseAllTaskJson
{
    public List<Task> Tasks { get; set; } = [];
}
