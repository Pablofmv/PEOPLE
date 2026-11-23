namespace Models;

public class Person
{
    public Guid Id {get; set;} = Guid.NewGuid();

    public string Name {get; set;} = string.Empty;

    public string Notes {get; set;} = string.Empty;

    public string AiSummary {get; set;} = string.Empty;

    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    
}