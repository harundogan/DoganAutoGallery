using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _006_DoganAutoGallery.Models
{
    public class Gallery
    {
        public int CarID { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Model Name")]
        public string ModelName { get; set; }
        [DisplayName("Car Year")]
        public int CarYear { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
        [DisplayName("License Plate")]
        public string LicensePlate { get; set; }
        [DisplayName("Current Status")]
        public string CurrentStatus { get; set; }
    }
}