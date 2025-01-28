using DesignPatterns.CreationalPatterns.AbstractFactory.Products;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

public class HolidayPriceCalculator : IPriceCalculator
{
    public ShippingDto CreateShippingPrice()
    {
        return new ShippingDto(2.3m);
    }

    public TaxDto CreateTaxPrice()
    {
        return new TaxDto(UserType.Normal, 0.07m);
    }
}