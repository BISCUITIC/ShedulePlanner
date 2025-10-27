namespace ShedulePlanner.Model.Subjects;

internal abstract record class Subject
{
    public string Name { get; init; } = null!;    
}
