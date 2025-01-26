using DesignPatterns.CreationalPatterns.AbstractFactory.Products;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

public interface IPriceCalculator
{
    IShippingPriceCalculator CreateShippingPriceCalculator();
    ITaxPriceCalculator CreateTaxPriceCalculator();
}