using ShedulePlanner.DataProviders.Interfaces;
using ShedulePlanner.Model;

namespace ShedulePlanner.DataProviders;

internal abstract class DataProvider : IClassroomsDataProvider, IGroupsDataProvider, ITeachersDataProvider
{
    public abstract IEnumerable<Classroom> GetClassrooms();
    public abstract IEnumerable<Group> GetGroups();
    public abstract IEnumerable<Teacher> GetTeachers();
    public abstract Task<IEnumerable<Classroom>> GetClassroomsAsync();
    public abstract Task<IEnumerable<Group>> GetGroupsAsync();
    public abstract Task<IEnumerable<Teacher>> GetTeacherAsync();
}
