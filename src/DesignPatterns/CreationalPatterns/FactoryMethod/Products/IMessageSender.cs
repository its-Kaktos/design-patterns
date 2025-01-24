namespace DesignPatterns.CreationalPatterns.FactoryMethod.Products;

public interface IMessageSender
{
    void OpenConnection();
    void CloseConnection();
    void Send(byte[] message);
}