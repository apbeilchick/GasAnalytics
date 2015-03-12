using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GasAnalytics.Models
{
    public class FillUp
    {
        [DisplayName("Fill Up Id")]
        public int FillUpId { get; set; }

        [Required]
        [DisplayName("Station Id")]
        public int StationId { get; set; }

        [Required]
        [DisplayName("Vehicle Id")]
        public int VehicleId { get; set; }

        [Required]
        public decimal Gallons { get; set; }

        [Required]
        [DisplayName("Price Per Gallon")]
        public decimal PricePerGallon { get; set; }

        [DisplayName("Trip Mileage")]
        public decimal TripMileage { get; set; }

        [DisplayName("Entered MPG")]
        public decimal? EnteredMPG { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Fill Up Date")]
        public DateTime FillUpDate { get; set; }
    }
}
