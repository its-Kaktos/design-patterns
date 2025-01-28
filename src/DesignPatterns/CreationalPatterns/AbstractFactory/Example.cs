using DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

namespace DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Abstract factory.
/// References:
///     https://refactoring.guru/design-patterns/abstract-factory
/// </summary>
public class Example
{
    public void Run(string args)
    {
        IPriceCalculator priceCalculator = args switch
        {
            "normal_day" => new NormalPriceCalculator(),
            "holiday" => new HolidayPriceCalculator(),
            _ => throw new InvalidOperationException()
        };

        var taxCalc = priceCalculator.CreateTaxPrice();
        var shippingPriceCalc = priceCalculator.CreateShippingPrice();
        Console.WriteLine($"Tax rate for you is {taxCalc}, and your discount rate is {shippingPriceCalc}");
    }
}