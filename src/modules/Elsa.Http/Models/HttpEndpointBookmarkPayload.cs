namespace Elsa.Http.Models;

public record HttpEndpointBookmarkPayload
{
    private readonly string _path = default!;
    private readonly string _method = default!;

    public HttpEndpointBookmarkPayload(string path, string method)
    {
        Path = path;
        Method = method;
    }

    public string Path
    {
        get => _path;
        init => _path = value.ToLowerInvariant();
    }

    public string Method
    {
        get => _method;
        init => _method = value.ToLowerInvariant();
    }
}