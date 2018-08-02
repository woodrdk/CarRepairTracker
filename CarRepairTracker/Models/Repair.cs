using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    public class Repair
    {
        [Key] // Makes the property the PK
        // If PK property is an integer, it will be an identity column by default.
        public int RepairID { get; set; }

        [Required] // You can use parentheses after required, but it is not required
        [StringLength(40)]
        public string Name { get; set; }

        [Range(0, 100000)] //Inclusive??
        [DataType(DataType.Currency)]
        public double LaborCost { get; set; }

        public double PartCost { get; set; }

        // public double LaborCost  { get; set; } need to set this up proper for foreign keys

        public double TotalCost { get; set; }

        public string ShopName { get; set; }

        public int Mileage { get; set; }

        public string Misc { get; set; }

        public DateTime RepairDate { get; set; }

        public virtual ICollection<Part> Parts { get; set; }

        // TODO: Add description
    }

}
