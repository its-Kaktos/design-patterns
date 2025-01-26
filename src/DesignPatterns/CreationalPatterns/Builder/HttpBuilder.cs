namespace DesignPatterns.CreationalPatterns.Builder;

public interface IHttpBuilder
{
    void Reset();
    void SetHeader(string header);
    void SetMethod(string method);
    void SetBody(string body);
    void SetUri(string uri);
}

public class HttpVersion1Dto
{
    public string Header { get; set; } = "";
    public string Method { get; set; } = "";
    public string Body { get; set; } = "";
    public string Uri { get; set; } = "";
}

public class HttpVersion2Dto : HttpVersion1Dto
{
}

public class HttpVersion1Builder : IHttpBuilder
{
    private HttpVersion1Dto _dto = new HttpVersion1Dto();

    public void Reset()
    {
        _dto = new HttpVersion1Dto();
    }

    public void SetHeader(string header)
    {
        _dto.Header = header;
    }

    public void SetMethod(string method)
    {
        _dto.Method = method;
    }

    public void SetBody(string body)
    {
        _dto.Body = body;
    }

    public void SetUri(string uri)
    {
        _dto.Uri = uri;
    }

    public HttpVersion1Dto Build()
    {
        var result = _dto;
        Reset();
        return result;
    }
}

public class HttpVersion2Builder : IHttpBuilder
{
    private HttpVersion2Dto _dto = new HttpVersion2Dto();

    public void Reset()
    {
        _dto = new HttpVersion2Dto();
    }

    public void SetHeader(string header)
    {
        _dto.Header = header;
    }

    public void SetMethod(string method)
    {
        _dto.Method = method;
    }

    public void SetBody(string body)
    {
        _dto.Body = body;
    }

    public void SetUri(string uri)
    {
        _dto.Uri = uri;
    }

    public HttpVersion2Dto Build()
    {
        var result = _dto;
        Reset();
        return result;
    }
}