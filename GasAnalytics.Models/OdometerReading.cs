using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasAnalytics.Models
{
    public class OdometerReading
    {
        [DisplayName("Odometer Reading Id")]
        public int OdometerReadingId { get; set; }

        [Required]
        [DisplayName("Car Id")]
        public int CarId { get; set; }

        [Required]
        [DisplayName("Mileage Reading")]
        public decimal MileageReading { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Reading Date")]
        public DateTime ReadingDate { get; set; }
    }
}
