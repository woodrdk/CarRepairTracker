using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    public class Trim
    {
        [Key] // Makes the property the PK
        // If PK property is an integer, it will be an identity column by default.
        public int TrimID { get; set; }

        [Required] // You can use parentheses after required, but it is not required
        [StringLength(20)]
        public string TrimName { get; set; }

        public virtual ICollection<Model> Models { get; set; }

    }
}
