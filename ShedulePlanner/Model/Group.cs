using ShedulePlanner.Model.Subjects;

namespace ShedulePlanner.Model;

internal record class Group
{
    public int Name { get; init; }
    public int StudentsNumber { get; init; }
    public List<Subject> CoreSubjects { get; init; } = null!;
}
