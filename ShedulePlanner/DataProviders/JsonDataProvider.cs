using ShedulePlanner.Model;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShedulePlanner.DataProviders;

internal class JsonDataProvider : DataProvider
{
    private const string DATA_DIRECTORY_PATH = "DataJson";
    
    private const string CLASSROOMS_FILE_PATH = "Classrooms.json";
    private const string GROUPS_FILE_PATH = "Groups.json";
    private const string TEACHERS_FILE_PATH = "Teachers.json";

    public override IEnumerable<Classroom> GetClassrooms()
    {
        using (FileStream fileStream = new FileStream(CreatePath(DATA_DIRECTORY_PATH,
                                                                 CLASSROOMS_FILE_PATH),
                                                      FileMode.OpenOrCreate))
        {
            IEnumerable<Classroom> classrooms = JsonSerializer.Deserialize<IEnumerable<Classroom>>(fileStream) ??
                                                Enumerable.Empty<Classroom>();
            return classrooms;
        }
    }
    public override async Task<IEnumerable<Classroom>> GetClassroomsAsync()
    {
        using (FileStream fileStream = new FileStream(CreatePath(DATA_DIRECTORY_PATH, 
                                                                 CLASSROOMS_FILE_PATH), 
                                                      FileMode.OpenOrCreate))
        {
            IEnumerable<Classroom> classrooms = await JsonSerializer.DeserializeAsync<IEnumerable<Classroom>>(fileStream)??
                                                      Enumerable.Empty<Classroom>();
            return classrooms;            
        }
    }

    public override IEnumerable<Group> GetGroups()
    {
        using (FileStream fileStream = new FileStream(CreatePath(DATA_DIRECTORY_PATH,
                                                                 GROUPS_FILE_PATH),
                                                      FileMode.OpenOrCreate))
        {
            IEnumerable<Group> groups = JsonSerializer.Deserialize<IEnumerable<Group>>(fileStream) ??
                                        Enumerable.Empty<Group>();
            return groups;
        }
    }
    public override async Task<IEnumerable<Group>> GetGroupsAsync()
    {
        using (FileStream fileStream = new FileStream(CreatePath(DATA_DIRECTORY_PATH,
                                                                 GROUPS_FILE_PATH),
                                                      FileMode.OpenOrCreate))
        {
            IEnumerable<Group> groups = await JsonSerializer.DeserializeAsync<IEnumerable<Group>>(fileStream) ??
                                              Enumerable.Empty<Group>();
            return groups;
        }
    }

    public override IEnumerable<Teacher> GetTeachers()
    {
        using (FileStream fileStream = new FileStream(CreatePath(DATA_DIRECTORY_PATH,
                                                                 TEACHERS_FILE_PATH),
                                                      FileMode.OpenOrCreate))
        {
            IEnumerable<Teacher> teachers = JsonSerializer.Deserialize<IEnumerable<Teacher>>(fileStream) ??
                                            Enumerable.Empty<Teacher>();
            return teachers;
        }
    }
    public override async Task<IEnumerable<Teacher>> GetTeacherAsync()
    {
        using (FileStream fileStream = new FileStream(CreatePath(DATA_DIRECTORY_PATH,
                                                                 TEACHERS_FILE_PATH),
                                                      FileMode.OpenOrCreate))
        {
            IEnumerable<Teacher> teachers = await JsonSerializer.DeserializeAsync<IEnumerable<Teacher>>(fileStream) ??
                                                  Enumerable.Empty<Teacher>();
            return teachers;
        }
    }

    private string CreatePath(params string[] strings)
    {
        return Path.Combine(strings);
    }
}
