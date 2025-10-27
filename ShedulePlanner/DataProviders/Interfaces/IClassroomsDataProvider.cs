using ShedulePlanner.Model;

namespace ShedulePlanner.DataProviders.Interfaces;

internal interface IClassroomsDataProvider
{
    IEnumerable<Classroom> GetClassrooms();
    Task<IEnumerable<Classroom>> GetClassroomsAsync();
}
