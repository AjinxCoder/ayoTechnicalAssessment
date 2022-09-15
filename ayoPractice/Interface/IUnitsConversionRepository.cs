using System.Threading.Tasks;

namespace ayoPractice.Interface
{
    public interface IUnitsConversionRepository
    {
        Task<decimal> MillimeterToInch(decimal milliMeter);
        Task<decimal> InchToMillimeter(decimal inch);
        Task<decimal> MilligramToGrain(decimal milligram);
        Task<decimal> GrainToMilligram(decimal grain);
        Task<decimal> CelsiusToFahrenheit(decimal celsius);
        Task<decimal> FahrenheitToCelsius(decimal fahrenheit);
    }
}