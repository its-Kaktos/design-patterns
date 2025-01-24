using DesignPatterns.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factory;

public class BrokerMessageSender : MessageSender
{
    protected override IMessageClient CreateClient()
    {
        return new BrokerClient();
    }
}