using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ayoPractice.Entities
{
    public class MetricImperialUnit
    {
        public int Id { get; set; }
        public string UnitCoversion { get; set; }
        [Column(TypeName = "decimal(18,5)")]
        public decimal ConversionRate { get; set; }
        [Column(TypeName = "decimal(18,5)")]
        public decimal CalculationConstant { get; set; }
    }
}
