using System.Text;
using DesignPatterns.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factory;

public abstract class MessageSender
{
    protected abstract IMessageSender CreateSender();

    public void Send(string message)
    {
        var sender = CreateSender();
        
        sender.OpenConnection();
        sender.Send(Encoding.UTF8.GetBytes(message));
        sender.CloseConnection();
    }
}