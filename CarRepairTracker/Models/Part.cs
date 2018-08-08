using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    /// <summary>
    /// Represents a car part.
    /// </summary>
    public class Part
    {
        [Key] // Makes the property the PK
              // If PK property is an integer, it will be an identity column by default.
        public int PartID { get; set; }

        public string PartNumber { get; set; }

        [Required] // You can use parentheses after required, but it is not required
        [StringLength(40)]
        public string PartName { get; set; }

        [Range(0, 100000)] //Inclusive??
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        // TODO: Add description

        public string PartBrand { get; set; }

        public int Qty { get; set; }
        public int RepairID { get; set; }
        public virtual Repair Repairs { get; set; }
    }
}
