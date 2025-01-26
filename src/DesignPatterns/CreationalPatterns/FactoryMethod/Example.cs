using DesignPatterns.CreationalPatterns.FactoryMethod.Factory;

namespace DesignPatterns.CreationalPatterns.FactoryMethod;

/// <summary>
/// Factory method design pattern.
/// References:
///     https://refactoring.guru/design-patterns/factory-method
///     https://www.youtube.com/watch?v=EdFq_JIThqM&ab_channel=Geekific
/// Note from reference:
/// Note that, despite its name, the creator's primary
/// responsibility isn't creating products. It usually
/// contains some core business logic that relies on product
/// objects returned by the factory method. Subclasses can
/// indirectly change that business logic by overriding the
/// factory method and returning a different type of product
/// from it.
///
/// We can use other things instead of factory method, e.g: using a func
/// or using a DI container.
/// </summary>
public class Example
{
    public void Run(string args)
    {
        const string message = "Hello world!";

        MessageSender messageSender = args switch
        {
            "http" => new HttpMessageSender(),
            "broker" => new BrokerMessageSender(),
            _ => throw new InvalidOperationException("args is not valid")
        };

        messageSender.Send(message);
    }
}