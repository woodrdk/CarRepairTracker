using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    public class Model
    {
        [Key] // Makes the property the PK
        // If PK property is an integer, it will be an identity column by default.
        public int ModelID { get; set; }

        [Required] // You can use parentheses after required, but it is not required
        [StringLength(40)]
        public string Name { get; set; }

        public int YearStarted { get; set; }

        public int? YearEnded { get; set; }

        // TODO: Add description
    }
}
