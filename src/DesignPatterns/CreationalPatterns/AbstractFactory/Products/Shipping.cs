namespace DesignPatterns.CreationalPatterns.AbstractFactory.Products;

public record ShippingDto(decimal Rate);

public interface IShippingPriceCalculator
{
    ShippingDto Calc(string city);
}

public class NormalDayShippingPriceCalculator : IShippingPriceCalculator
{
    public ShippingDto Calc(string city)
    {
        return new ShippingDto(12.3m);
    }
}

public class HolidayShippingPriceCalculator : IShippingPriceCalculator
{
    public ShippingDto Calc(string city)
    {
        return new ShippingDto(2.3m);
    }
}