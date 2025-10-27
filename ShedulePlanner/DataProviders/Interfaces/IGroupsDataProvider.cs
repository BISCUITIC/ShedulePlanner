using ShedulePlanner.Model;

namespace ShedulePlanner.DataProviders.Interfaces;

internal interface IGroupsDataProvider
{
    IEnumerable<Group> GetGroups();
    Task<IEnumerable<Group>> GetGroupsAsync();
}
