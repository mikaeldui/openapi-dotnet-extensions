using Microsoft.OpenApi.Any;

namespace Microsoft.OpenApi;

public static class OpenApiAnyExtensions
{
    public static void AddRange(this IList<IOpenApiAny> anyList, IEnumerable<IOpenApiAny> toAdd)
    {
        foreach (var openApiAny in toAdd) anyList.Add(openApiAny);
    }

    public static void AddString(this IList<IOpenApiAny> anyList, string @string)
    {
        anyList.Add(new OpenApiString(@string));
    }

    public static void AddStrings(this IList<IOpenApiAny> anyList, IEnumerable<string> strings)
    {
        foreach (var @string in strings) anyList.AddString(@string);
    }
}