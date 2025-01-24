using DesignPatterns.CreationalPatterns.FactoryMethod.Products;
using HttpClient = DesignPatterns.CreationalPatterns.FactoryMethod.Products.HttpClient;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factory;

public class HttpMessageSender : MessageSender
{
    protected override IMessageSender CreateSender()
    {
        return new HttpClient();
    }
}