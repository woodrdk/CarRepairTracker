using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        // next two are for foreign key
        // [ForeignKey("Makes")]
       // public int MakeID { get; set; }
        public virtual Make Makes { get; set; }

        // TODO: Add description


        public static List<Model> GetAllModels(String make, String year)
        {
            
            using (CarRepairDbContext context = new CarRepairDbContext())
            {
                int ModelYear = Int32.Parse(year); // converts string value of the year to an int for search purposes
                var allModels =
                    (from ModelName in context.Models
                     where (                                    // where
                            (ModelName.YearStarted <= ModelYear)      // year make started is less than or equal to the year looking for
                           )
                                   &&                           // and
                           (
                            (ModelName.YearEnded >= ModelYear)        // where  the brand ended was equal to or after the year selected
                                   ||                           // or
                            (ModelName.YearEnded == null)            // brand is still in existance currently
                           )
                   
                           // -------------- need to add brand id variable
                     select ModelName).ToList();
                List<Model> Models = allModels.ToList();

                return Models;
            }
        }



    }
}
