using DesignPatterns.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factory;

public class BrokerMessageSender : MessageSender
{
    protected override IMessageSender CreateSender()
    {
        return new BrokerClient();
    }
}