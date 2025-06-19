﻿using Tasks.Communication.Enums;

namespace Tasks.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public DateTime DueDate { get; set; }
    public StatusType Status { get; set; }
}
