using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Products;

public class HttpClient : IMessageClient
{
    private const string Name = nameof(HttpClient);

    public void OpenConnection()
    {
        Console.WriteLine(Name + " connection opened.");
    }

    public void CloseConnection()
    {
        Console.WriteLine(Name + " connection closed.");
    }

    public void Send(byte[] message)
    {
        Console.WriteLine(Name + " send message: " + Encoding.UTF8.GetString(message));
    }
}