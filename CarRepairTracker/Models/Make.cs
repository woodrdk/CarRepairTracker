using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    public class Make
    {
        [Key] // Makes the property the PK
        // If PK property is an integer, it will be an identity column by default.
        public int MakeID { get; set; }

        [Required] // You can use parentheses after required, but it is not required
        [StringLength(40)]
        public string Name { get; set; }
        
        public int YearStarted { get; set; }

        public int? YearEnded { get; set; }

        // TODO: Add description


            // ----------- needs finished- -----------------
        public static List<Make> GetAllMakes(String year)
        {
            int MakeYear = Int16.Parse(year);
            using (CarRepairDbContext context = new CarRepairDbContext())
            {
                var allMakes =
                    (from Make in context.Makes
                     where ( Make.YearStarted <= MakeYear )
                        && ((Make.YearEnded >= MakeYear)) //|| (Make.YearEnded == null));
                     select Make).ToList();
                List<Make> Makes = allMakes.ToList();

                return allMakes;
            }
        }

                  


    }
}
