using System.Text;
using DesignPatterns.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factory;

public abstract class MessageSender
{
    protected abstract IMessageClient CreateClient();

    public void Send(string message)
    {
        var sender = CreateClient();

        sender.OpenConnection();
        sender.Send(Encoding.UTF8.GetBytes(message));
        sender.CloseConnection();
    }
}