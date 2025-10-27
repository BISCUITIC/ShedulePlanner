using ShedulePlanner.Model;

namespace ShedulePlanner.DataProviders.AuditoriumDataProvider;

internal interface IClassroomsDataProvider
{
    IEnumerable<Classroom> GetClassrooms();
}
