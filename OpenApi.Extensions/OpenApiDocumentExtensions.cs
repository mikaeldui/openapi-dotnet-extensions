using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi;

public static class OpenApiDocumentExtensions
{
    /// <summary>
    ///     Serializes the <see cref="OpenApiDocument" /> as <see cref="OpenApiSpecVersion.OpenApi3_0" />.
    /// </summary>
    public static string? SerializeAsV3Json(this OpenApiDocument document)
    {
        return document.SerializeAsJson(OpenApiSpecVersion.OpenApi3_0);
    }

    /// <summary>
    ///     Serializes the <see cref="OpenApiDocument" /> as <see cref="OpenApiSpecVersion.OpenApi3_0" />.
    /// </summary>
    public static string? SerializeAsV3Yaml(this OpenApiDocument document)
    {
        return document.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
    }

    /// <summary>
    ///     Serializes the <see cref="OpenApiDocument" /> as <see cref="OpenApiSpecVersion.OpenApi3_0" /> and writes it to the
    ///     file.
    /// </summary>
    /// <param name="path">Creates the files if it doesn't exist, and overwrites it if it exists.</param>
    public static async Task WriteAsV3JsonAsync(this OpenApiDocument document, string path)
    {
        var openApiJson = document.SerializeAsV3Json();
        await File.WriteAllTextAsync(path, openApiJson);
    }

    /// <summary>
    ///     Serializes the <see cref="OpenApiDocument" /> as <see cref="OpenApiSpecVersion.OpenApi3_0" /> and writes it to the
    ///     file.
    /// </summary>
    /// <param name="path">Creates the files if it doesn't exist, and overwrites it if it exists.</param>
    public static async Task WriteAsV3YamlAsync(this OpenApiDocument document, string path)
    {
        var openApiYaml = document.SerializeAsV3Yaml();
        await File.WriteAllTextAsync(path, openApiYaml);
    }
}