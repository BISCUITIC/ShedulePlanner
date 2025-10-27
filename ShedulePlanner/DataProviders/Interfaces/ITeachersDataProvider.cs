using ShedulePlanner.Model;

namespace ShedulePlanner.DataProviders.Interfaces;

internal interface ITeachersDataProvider
{
    IEnumerable<Teacher> GetTeachers();
    Task<IEnumerable<Teacher>> GetTeacherAsync();
}
