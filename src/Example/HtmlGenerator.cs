namespace Example;

public class HtmlGenerator
{
    private readonly List<string> _snippets = new();

    public void Add(string html)
    {
        _snippets.Add(html);
    }

    public string Combine()
    {
        return string.Join("", _snippets.ToArray());
    }
}