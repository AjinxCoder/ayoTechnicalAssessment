using ayoPractice.Data;
using ayoPractice.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ayoPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitsConversionController : ControllerBase
    {
        private readonly IUnitsConversionRepository unitsConversionRepository;

        public UnitsConversionController(IUnitsConversionRepository unitsConversionRepository)
        {
            this.unitsConversionRepository = unitsConversionRepository;
        }
        
        [HttpGet("CelsiusToFahrenheit/{celsius}")]
        public async Task<ActionResult<decimal>> CelsiusToFahrenheit(decimal celsius)
        {
            return await unitsConversionRepository.CelsiusToFahrenheit(celsius);

        }

        [HttpGet("FahrenheitToCelsius/{fahrenheit}")]
        public async Task<ActionResult<decimal>> FahrenheitToCelsius(decimal fahrenheit)
        {
            return await unitsConversionRepository.FahrenheitToCelsius(fahrenheit);

        }

        [HttpGet("GrainToMilligram/{grain}")]
        public async Task<ActionResult<decimal>> GrainToMilligram(decimal grain)
        {
            return await unitsConversionRepository.GrainToMilligram(grain);

        }

        [HttpGet("InchToMillimeter/{inch}")]
        public async Task<ActionResult<decimal>> InchToMillimeter(decimal inch)
        {
            return await unitsConversionRepository.InchToMillimeter(inch);

        }

        [HttpGet("MilligramToGrain/{milligram}")]
        public async Task<ActionResult<decimal>> MilligramToGrain(decimal milligram)
        {
            return await unitsConversionRepository.MilligramToGrain(milligram);

        }
        
        [HttpGet("MillimeterToInch/{millimeter}")]
        public async Task<ActionResult<decimal>> MillimeterToInch(decimal millimeter)
        {
            return await unitsConversionRepository.MillimeterToInch(millimeter);

        }
    }
}
