using DesignPatterns.CreationalPatterns.AbstractFactory.Products;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

public class NormalPriceCalculator : IPriceCalculator
{
    public IShippingPriceCalculator CreateShippingPriceCalculator()
    {
        return new NormalDayShippingPriceCalculator();
    }

    public ITaxPriceCalculator CreateTaxPriceCalculator()
    {
        return new NormalDayTaxPriceCalculator();
    }
}