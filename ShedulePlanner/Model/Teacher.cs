using ShedulePlanner.Model.Subjects;

namespace ShedulePlanner.Model;

internal record class Teacher
{
    public string Name { get; init; }
    public Subject TeachingSubjects { get; init; }
}
