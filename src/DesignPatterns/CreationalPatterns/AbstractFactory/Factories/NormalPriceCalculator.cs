using DesignPatterns.CreationalPatterns.AbstractFactory.Products;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

public class NormalPriceCalculator : IPriceCalculator
{
    public ShippingDto CreateShippingPrice()
    {
        return new ShippingDto(23.2m);
    }

    public TaxDto CreateTaxPrice()
    {
        return new TaxDto(UserType.Normal, 0.9m);
    }
}