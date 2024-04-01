using Microsoft.AspNetCore.Mvc;
using LaptopManagementSystem.Models;
using LaptopManagementSystem.Repositories;
using System.Collections.Generic;

namespace LaptopManagementSystem.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly LaptopRepository repo;

        public LaptopsController()
        {
            repo = new LaptopRepository();
        }

        public IActionResult Index()
        {
            List<Laptop> laptops = repo.GetLaptops();
            return View(laptops);
        }

        public IActionResult Details(int id)
        {
            Laptop laptop = repo.FindLaptop(id);
            return View(laptop);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Laptop laptop)
        {
            repo.InsertLaptop(laptop.BrandId, laptop.ModelId, laptop.ProcessorId, laptop.RAMId, laptop.SerialNumber, laptop.PurchaseDate);
            ViewData["MENSAJE"] = "Laptop inserted";
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Laptop laptop = repo.FindLaptop(id);
            return View(laptop);
        }

        [HttpPost]
        public IActionResult Update(Laptop laptop)
        {
            repo.UpdateLaptop(laptop.LaptopId, laptop.BrandId, laptop.ModelId, laptop.ProcessorId, laptop.RAMId, laptop.SerialNumber, laptop.PurchaseDate);
            ViewData["MENSAJE"] = "Laptop updated";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            repo.DeleteLaptop(id);
            return RedirectToAction("Index");
        }
    }
}