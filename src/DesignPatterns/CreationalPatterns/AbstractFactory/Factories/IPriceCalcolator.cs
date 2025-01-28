using DesignPatterns.CreationalPatterns.AbstractFactory.Products;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

public interface IPriceCalculator
{
    ShippingDto CreateShippingPrice();
    TaxDto CreateTaxPrice();
}