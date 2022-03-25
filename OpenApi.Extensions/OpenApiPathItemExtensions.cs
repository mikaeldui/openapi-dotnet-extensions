using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi;

public static class OpenApiPathItemExtensions
{
    /// <summary>
    ///     Add one operation into this path item.
    /// </summary>
    /// <param name="operationType">Not case-sensitive.</param>
    public static void AddOperation(this OpenApiPathItem pathItem, string operationType, OpenApiOperation operation)
    {
        pathItem.AddOperation(Enum.Parse<OperationType>(operationType, true), operation);
    }
}