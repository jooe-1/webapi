using System.Text.Json.Serialization;

namespace webapi;

public record ArrayHolder<T>(T[] Data);

public static class ArrayHolder
{
    public static ArrayHolder<T> Create<T>(IEnumerable<T> collection)
        => new([.. collection]);
}