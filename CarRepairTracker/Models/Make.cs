using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        // for foreign key not working //
        public virtual ICollection<Model> Models { get; set; }



        public static List<Make> GetAllMakes(String year)        //this method searches for the makes available in a selected year
        {
            int MakeYear = Int32.Parse(year); // converts string value of the year to an int for search purposes
            using (CarRepairDbContext context = new CarRepairDbContext())   // connects to DB
            {
                var allMakes =  // makes a list of all makes
                    (from Make in context.Makes     // searches the makes table for all makes names
                     where (                                    // where
                            (Make.YearStarted <= MakeYear)      // year make started is less than or equal to the year looking for
                           )
                                   &&                           // and
                           (
                            (Make.YearEnded >= MakeYear)        // where  the brand ended was equal to or after the year selected
                                   ||                           // or
                            (Make.YearEnded == null)            // brand is still in existance currently
                           )
                     select Make).ToList();                     // selects the proper values, then puts them to list 
                List<Make> Makes = allMakes.ToList();           // moves the list to the Makes List

                return Makes;                                   // returns list of selected values
            }
        }


        
        



    }
}
