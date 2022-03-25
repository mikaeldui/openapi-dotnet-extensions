using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi;

public static class OpenApiTagExtensions
{
    /// <summary>
    ///     Adds a new <see cref="OpenApiTag" />.
    /// </summary>
    public static void Add(this IList<OpenApiTag> tags, string name)
    {
        tags.Add(new OpenApiTag {Name = name});
    }

    /// <summary>
    ///     Adds a new <see cref="OpenApiTag" />.
    /// </summary>
    public static void Add(this IList<OpenApiTag> tags, string name, string description)
    {
        tags.Add(new OpenApiTag {Name = name, Description = description});
    }

    /// <summary>
    ///     Adds tags, if they don't already exist.
    /// </summary>
    /// <param name="tags">The list of tags to append.</param>
    /// <param name="tagNames">The name of the tags to add.</param>
    public static void AddRange(this IList<OpenApiTag> tags, IEnumerable<string> tagNames)
    {
        foreach (var tagName in tagNames.Where(tn => tags.All(t => t.Name != tn)))
            tags.Add(new OpenApiTag {Name = tagName});
    }

    /// <summary>
    ///     Adds tags, if they don't already exist, else updates their description. Can be used to removed descriptions of
    ///     existing tags.
    /// </summary>
    /// <param name="tags">The list of tags to update.</param>
    /// <param name="newTags">The tags to add or update.</param>
    public static void AddRange(this IList<OpenApiTag> tags, IEnumerable<KeyValuePair<string, string?>> newTags)
    {
        foreach (var (tagName, tagDescription) in newTags)
            if (tags.All(t => t.Name != tagName))
                tags.Add(new OpenApiTag {Name = tagName, Description = tagDescription});
            else
                foreach (var existingTag in tags.Where(t => t.Name == tagName))
                    existingTag.Description = tagDescription;
    }
}