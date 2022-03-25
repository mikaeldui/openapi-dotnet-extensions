using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi;

public static class OpenApiOperationExtensions
{
    private const string MEDIA_TYPE_JSON = "application/json";
    private const string MEDIA_TYPE_YAML = "application/x-yaml";
    private const string MEDIA_TYPE_MSGPACK = "application/x-msgpack";

    public static void AddRequestBodyJson(this OpenApiOperation operation, OpenApiMediaType mediaTypeObject)
    {
        operation.RequestBody ??= new OpenApiRequestBody();
        operation.RequestBody.Content[MEDIA_TYPE_JSON] = mediaTypeObject;
    }

    public static void AddRequestBodyJson(this OpenApiOperation operation, OpenApiSchema schema)
    {
        operation.AddRequestBodyJson(new OpenApiMediaType {Schema = schema});
    }

    public static void AddRequestBodyYaml(this OpenApiOperation operation, OpenApiMediaType mediaTypeObject)
    {
        operation.RequestBody ??= new OpenApiRequestBody();
        operation.RequestBody.Content[MEDIA_TYPE_YAML] = mediaTypeObject;
    }

    public static void AddRequestBodyYaml(this OpenApiOperation operation, OpenApiSchema schema)
    {
        operation.AddRequestBodyYaml(new OpenApiMediaType {Schema = schema});
    }

    public static void AddRequestBodyMsgPack(this OpenApiOperation operation, OpenApiMediaType mediaTypeObject)
    {
        operation.RequestBody ??= new OpenApiRequestBody();
        operation.RequestBody.Content[MEDIA_TYPE_MSGPACK] = mediaTypeObject;
    }

    public static void AddRequestBodyMsgPack(this OpenApiOperation operation, OpenApiSchema schema)
    {
        operation.AddRequestBodyMsgPack(new OpenApiMediaType {Schema = schema});
    }
}