﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker.Models
{
    public class UserCar
    {
        //---------------- change all this properly
        [Key] // Makes the property the PK
              // If PK property is an integer, it will be an identity column by default.
        [Required]
        public int UserCarId { get; set;}
        
       
        //public int UserId { get; set; }
        [StringLength(40)]
        public String CarNameDescription { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Trim { get; set; }
        public string Engine { get; set; }

        [StringLength(17)]
        public string  Vin { get; set; }

        [StringLength(8)]
        public string Plate { get; set; }
        public string State { get; set; }
        public string Color { get; set; }

        [StringLength(100)]
        public string UniqueIdentifiers { get; set; }

        public string OilGrade { get; set; }
        public string OilFilter { get; set; }
        public string AirFilter { get; set; }
        public string SparkPlugs { get; set; }
        public string HeadlightBulb { get; set; }
        public string TireSize { get; set; }

        public DateTime? PurchaseDate{ get; set; }

       // [DataType(DataType.Currency)]
        public double PurchasePrice { get; set; }

        public int PurchaseMileage { get; set; }
        public bool Warranty { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int ExpirationMileage { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }
       
        public int UserId { get; set; }

        [StringLength(int.MaxValue)]
        public string Notes { get; set; }



        public static List<UserCar> GetAllUserCars()
        {
            using (CarRepairDbContext context = new CarRepairDbContext())
            {
                var GetAllUserCar =
                    (from carUser in context.UserCars
                     where (
                           (IntroWho.whoUsing == carUser.UserId)
                           )

                     select carUser).ToList();

                List<UserCar> UserCars = GetAllUserCar.ToList();

                return GetAllUserCar;
            }
        }


    }
}
