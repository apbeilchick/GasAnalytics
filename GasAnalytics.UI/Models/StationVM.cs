using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GasAnalytics.UI.Models
{
    public class StationVM
    {
        [DisplayName("Station Id")]
        public int StationId { get; set; }

        [Required]
        [DisplayName("Station Chain Id")]
        public int StationChainId { get; set; }

        [DisplayName("Station Number")]
        public int StationNum { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Adddress 1")]
        public string Address1 { get; set; }

        [DisplayName("Address 2 (Optional)")]
        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:(###)-###-####}", ApplyFormatInEditMode = true)]
        public Int64 Phone { get; set; }

        public virtual StationChainVM StationChain { get; set; }
    }
}