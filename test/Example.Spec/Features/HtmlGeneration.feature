Feature: HtmlGeneration
	Example of issue with Veify

Scenario: Concatenate two HTML snippets
	Given the first snippet is a paragraph
	And the second snippet is an image
	When the two snippets are concatenated
	Then the result should be a combination of the snippets