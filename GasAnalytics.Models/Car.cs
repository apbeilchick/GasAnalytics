using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GasAnalytics.Models
{
    public class Car
    {
        [DisplayName("Car Id")]
        public int CarId { get; set; }
        
        public string Name { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }        

        public virtual ICollection<OdometerReading> OdometerReadings { get; set; }

        public virtual ICollection<FillUp> FillUps { get; set; }
    }
}
