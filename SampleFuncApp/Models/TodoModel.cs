using System;

namespace SampleFuncApp.Models;

public class TodoModel
{
    public Guid Id { get; set; }
    
    public string Subject { get; set; }
    
    public DateTime? DueDate { get; set; }
    
    public bool IsComplete { get; set;  }
}
