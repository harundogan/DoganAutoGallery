using _006_DoganAutoGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _006_DoganAutoGallery.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult ListCars()
        {
            return View(CarData.gallery);
        }

        public ActionResult AddNewCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewCar(Gallery VehicleToAdd)
        {
            CarData.gallery.Add(VehicleToAdd);
            return RedirectToAction("ListCars");
        }

        public ActionResult EditCar(int id)
        {
            Gallery editCar = CarData.gallery.FirstOrDefault(g => g.CarID == id);
            return View(editCar);
        }
        [HttpPost]
        public ActionResult EditCar(int id,Gallery DuzenlenecekArac)
        {
            Gallery editCar = CarData.gallery.FirstOrDefault(g => g.CarID == id);
            CarData.gallery.Remove(editCar);
            Gallery carGallery = new Gallery {CarID = id,BrandName = DuzenlenecekArac.BrandName,ModelName = DuzenlenecekArac.ModelName,Price = DuzenlenecekArac.Price,CarYear = DuzenlenecekArac.CarYear,LicensePlate = DuzenlenecekArac.LicensePlate,CurrentStatus = DuzenlenecekArac.CurrentStatus };
            CarData.gallery.Add(carGallery);
            return RedirectToAction("ListCars");
        }

        public ActionResult CarDetails(int id)
        {
            Gallery editCar = CarData.gallery.FirstOrDefault(g => g.CarID == id);
            return View(editCar);
        }

        public ActionResult DeleteCar(int id)
        {
            Gallery deleteCar = CarData.gallery.FirstOrDefault(g => g.CarID == id);
            return View(deleteCar);
        }
        [HttpPost]
        public ActionResult DeleteCurrentCar(int id)
        {
            Gallery deleteCar = CarData.gallery.FirstOrDefault(g => g.CarID == id);
            CarData.gallery.Remove(deleteCar);
            return RedirectToAction("ListCars");
        }
    }
}