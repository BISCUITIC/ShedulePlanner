using ShedulePlanner.DataProviders;
using ShedulePlanner.Model;

namespace ShedulePlanner;

internal class Program
{
    private static async Task Main(string[] args)
    {
        JsonDataProvider dataProvider = new JsonDataProvider();

        Task<IEnumerable<Classroom>> classroomsTask = dataProvider.GetClassroomsAsync();
        Task<IEnumerable<Group>> groupsTask = dataProvider.GetGroupsAsync();
        Task<IEnumerable<Teacher>> teachersTask = dataProvider.GetTeacherAsync();

        var classrooms = await classroomsTask;
        var groups = await groupsTask;
        var teachers = await teachersTask;

        foreach (var classroom in classrooms)
        {
            Console.WriteLine(classroom);
        }
        foreach (var group in groups)
        {
            Console.WriteLine(group);
        }
        foreach (var teacher in teachers)
        { 
            Console.WriteLine(teacher); 
        }
    }
}
 