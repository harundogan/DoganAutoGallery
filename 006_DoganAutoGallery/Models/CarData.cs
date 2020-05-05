using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _006_DoganAutoGallery.Models
{
    public class CarData
    {
        public static List<Gallery> gallery = new List<Gallery>
        {
            new Gallery {CarID = 1,BrandName = "Ford",ModelName = "Focus",LicensePlate = "34AB5225",CarYear=2017,CurrentStatus="Sold",Price = 95000},
            new Gallery {CarID = 2,BrandName = "Audi",ModelName = "A5",LicensePlate = "35BT2756",CarYear=2016,CurrentStatus="Active",Price = 83000},
            new Gallery {CarID = 3,BrandName = "Volkswagen",ModelName = "Passat",LicensePlate = "06BC5838",CarYear=2018,CurrentStatus="Sold",Price = 220000},
            new Gallery {CarID = 4,BrandName = "Hyundai",ModelName = "i30",LicensePlate = "34PJT858",CarYear=2017,CurrentStatus="Rent",Price = 100000},
            new Gallery {CarID = 5,BrandName = "Skoda",ModelName = "Octavia",LicensePlate = "07BH5821",CarYear=2018,CurrentStatus="Active",Price = 160000},
            new Gallery {CarID = 6,BrandName = "Seat",ModelName = "Leon",LicensePlate = "34PM1958",CarYear=2019,CurrentStatus="Sold",Price = 175000},
            new Gallery {CarID = 7,BrandName = "Ford",ModelName = "Mondeo",LicensePlate = "03FN582",CarYear=2017,CurrentStatus="Sold",Price = 140000},
            new Gallery {CarID = 8,BrandName = "Volkswagen",ModelName = "Jetta",LicensePlate = "34MC9682",CarYear=2016,CurrentStatus="Active",Price = 1350000}
        };
    }
}