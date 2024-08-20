using System.Data.Common;
using Bulky.DataAccess.Data;
using Bulky.Models;
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

        // CREATE METHOD
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
                TempData["success"] = "Category created successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        // PUT METHOD
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0) return NotFound();
            Category? categoryFromDb = _db.Categories.Find(id);
            if(categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        // DELETE METHOD
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0) return NotFound();
            Category? categoryFromDb = _db.Categories.Find(id);
            if(categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category obj = _db.Categories.Find(id);
            if(obj == null) return NotFound();
            
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
