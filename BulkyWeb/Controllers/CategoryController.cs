using System.Data.Common;
using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController(ApplicationDBContext db) : Controller
    {
        private readonly ApplicationDBContext _db = db;

        // GET: CategoryController
        public IActionResult Index()
        {
            List<Category> objCategoryList = [.. _db.Categories];
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            // Custom Validation with custom error message
            // if(obj.Name.ToLower() == obj.DisplayOrder.ToString())
            // {
            //     ModelState.AddModelError("name", "Display Order and Category Name cannot have same value");
            // }
            // if(obj.Name != null && obj.Name == "test")
            // {
            //     ModelState.AddModelError("", "Test is an Invalid value");
            // }
            if(ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
