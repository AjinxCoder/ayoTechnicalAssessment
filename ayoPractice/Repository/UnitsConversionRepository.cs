using ayoPractice.Data;
using ayoPractice.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ayoPractice.Repository
{
    public class UnitsConversionRepository : IUnitsConversionRepository
    {
        private readonly DataContext Context;

        public UnitsConversionRepository(DataContext context)
        {
            Context = context;
        }
        public async Task<decimal> CelsiusToFahrenheit(decimal celsius)
        {
            var conversionRate = await Context.MetricImperialUnits
                                    .Where(x => x.UnitCoversion == "CelsiusToFahrenheit")
                                    .Select(x => x.ConversionRate)
                                    .SingleOrDefaultAsync();

            var fahrenheit = celsius * conversionRate + 32;
            return fahrenheit;
        }

        public async Task<decimal> FahrenheitToCelsius(decimal fahrenheit)
        {
            var conversionRate = await Context.MetricImperialUnits
                                    .Where(x => x.UnitCoversion == "CelsiusToFahrenheit")
                                    .Select(x => x.ConversionRate)
                                    .SingleOrDefaultAsync();

            var celsius = (fahrenheit - 32) / conversionRate;
            return celsius;
        }

        public async Task<decimal> GrainToMilligram(decimal grain)
        {
            var conversionRate = await Context.MetricImperialUnits
                                    .Where(x => x.UnitCoversion == "MilligramToGrain")
                                    .Select(x => x.ConversionRate)
                                    .SingleOrDefaultAsync();

            var milligram = grain * conversionRate;
            return milligram;
        }

        public async Task<decimal> InchToMillimeter(decimal inch)
        {
            var conversionRate = await Context.MetricImperialUnits
                                    .Where(x => x.UnitCoversion == "MillimeterToInch")
                                    .Select(x => x.ConversionRate)
                                    .SingleOrDefaultAsync();

            var milliMeter = inch / conversionRate;
            return milliMeter;
        }

        public async Task<decimal> MilligramToGrain(decimal milligram)
        {
            var conversionRate = await Context.MetricImperialUnits
                                    .Where(x => x.UnitCoversion == "MilligramToGrain")
                                    .Select(x => x.ConversionRate)
                                    .SingleOrDefaultAsync();

            var grain = milligram * conversionRate;
            return grain;
        }

        public async Task<decimal> MillimeterToInch(decimal milliMeter)
        {
            var conversionRate = await Context.MetricImperialUnits
                                    .Where(x => x.UnitCoversion == "MillimeterToInch")
                                    .Select(x => x.ConversionRate)
                                    .SingleOrDefaultAsync();

            var inch = milliMeter * conversionRate;
            return inch;
        }
    }
}
