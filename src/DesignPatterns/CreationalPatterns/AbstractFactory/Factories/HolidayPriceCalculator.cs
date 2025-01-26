using DesignPatterns.CreationalPatterns.AbstractFactory.Products;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

public class HolidayPriceCalculator : IPriceCalculator
{
    public IShippingPriceCalculator CreateShippingPriceCalculator()
    {
        return new HolidayShippingPriceCalculator();
    }

    public ITaxPriceCalculator CreateTaxPriceCalculator()
    {
        return new HolidayTaxPriceCalculator();
    }
}