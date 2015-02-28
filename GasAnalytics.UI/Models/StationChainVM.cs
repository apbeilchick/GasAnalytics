using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GasAnalytics.UI.Models
{
    public class StationChainVM
    {
        [DisplayName("Station Chain Id")]
        public int StationChainId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<StationVM> Stations { get; set; }
    }
}