using System.Text.Json.Serialization;

namespace ShedulePlanner.Model.Subjects;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(Lecture), "Lecture")]
[JsonDerivedType(typeof(Tutorial), "Tutorial")]
internal abstract record class Subject
{
    public string Name { get; init; } = null!;    
}
