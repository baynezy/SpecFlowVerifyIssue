namespace Example.Spec.Steps;

[Binding]
[UsesVerify]
public class HtmlGeneratorStepDefinitions
{
    private readonly HtmlGenerator _htmlGenerator = new();
    private string? _result;

    [Given(@"the first snippet is a paragraph")]
    public void GivenTheFirstSnippetIsAParagraph()
    {
        const string paragraph = @"<p>This is a paragraph</p>";
        _htmlGenerator.Add(paragraph);
    }

    [Given(@"the second snippet is an image")]
    public void GivenTheSecondSnippetIsAnImage()
    {
        const string image = @"<img src=""/some/path.jpg"" />";
        _htmlGenerator.Add(image);
    }

    [When(@"the two snippets are concatenated")]
    public void WhenTheTwoSnippetsAreConcatenated()
    {
        _result = _htmlGenerator.Combine();
    }

    [Then(@"the result should be a combination of the snippets")]
    public async Task ThenTheResultShouldBeACombinationOfTheSnippets()
    {
        await Verify(_result);
    }
}