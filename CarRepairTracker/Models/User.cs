using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    public class User
    {
        [Key] // Makes the property the PK
        // If PK property is an integer, it will be an identity column by default.
        public int UserID { get; set; }

        [Required] // You can use parentheses after required, but it is not required
        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        // TODO: Add description
    }
}
