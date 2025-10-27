using ShedulePlanner.Model.Subjects;

namespace ShedulePlanner.Model;

internal record class Teacher
{
    public string Name { get; init; } = null!;
    public List<Subject> TeachingSubjects { get; init; } = null!;
}
