namespace DesignPatterns.CreationalPatterns.AbstractFactory.Products;

public enum UserType
{
    Guest,
    Normal,
    Vip
}

public record TaxDto(UserType UserType, decimal Rate);