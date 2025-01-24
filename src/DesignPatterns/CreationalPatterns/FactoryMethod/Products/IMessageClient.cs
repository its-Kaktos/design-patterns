namespace DesignPatterns.CreationalPatterns.FactoryMethod.Products;

public interface IMessageClient
{
    void OpenConnection();
    void CloseConnection();
    void Send(byte[] message);
}