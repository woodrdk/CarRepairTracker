using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
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

        public virtual ICollection<UserCar> UserCars { get; set; }
        

        // TODO: Add description

        public static List<User> GetAllUsers()
        {
            using (CarRepairDbContext context = new CarRepairDbContext())
            {
                var allUsers =
                    (from c in context.Users
                     select c).ToList();
                List<User> Users = allUsers.ToList();

                return allUsers;
            }
        }


        public static void Delete(User person)
        { // not working
            var context = new CarRepairDbContext();
            context.Users.Add(person);
            context.Entry(person).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
