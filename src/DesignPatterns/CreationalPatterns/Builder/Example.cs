namespace DesignPatterns.CreationalPatterns.Builder;

/// <summary>
/// Builder pattern.
/// References:
///     https://refactoring.guru/design-patterns/builder
///
/// Note:
///     There are many variants of this pattern.
///     E.g: some will return their interface so we can
///     use method chaining. Also, we can create a director
///     class that can use our builder and build in a specific
///     sequence or using default values.
/// </summary>
public class Example
{
    public void Run(string args)
    {
        var builder = new HttpVersion1Builder();

        builder.SetMethod("post");
        builder.SetBody("hello");
        builder.SetUri("someUri");
        var httpVersion1Dto = builder.Build();

        Console.WriteLine($"This is the result body {httpVersion1Dto.Body}");
    }
}