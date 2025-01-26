namespace DesignPatterns.CreationalPatterns.AbstractFactory.Products;

public enum UserType
{
    Guest,
    Normal,
    Vip
}

public record Tax(UserType UserType, decimal Rate);

public interface ITaxPriceCalculator
{
    Tax Calc(UserType userType);
}

public class NormalDayTaxPriceCalculator : ITaxPriceCalculator
{
    public Tax Calc(UserType userType)
    {
        return new Tax(userType, 0.07m);
    }
}

public class HolidayTaxPriceCalculator : ITaxPriceCalculator
{
    public Tax Calc(UserType userType)
    {
        return new Tax(userType, 0.03m);
    }
}