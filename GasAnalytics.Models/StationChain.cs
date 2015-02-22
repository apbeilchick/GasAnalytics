using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasAnalytics.Models
{
    public class StationChain
    {
        [DisplayName("Station Chain Id")]
        public int StationChainId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Station> Stations { get; set; }
    }
}
