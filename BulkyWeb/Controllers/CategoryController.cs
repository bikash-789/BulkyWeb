using System.Data.Common;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController(IUnitOfWork unitOfWork) : Controller
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        // GET: CategoryController
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
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
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        // PUT METHOD
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0) return NotFound();
            Category? categoryFromDb = _unitOfWork.Category.Get(u=>u.Id == id);
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
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        // DELETE METHOD
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0) return NotFound();
            Category? categoryFromDb = _unitOfWork.Category.Get(u=>u.Id == id);
            if(categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category obj = _unitOfWork.Category.Get(u=>u.Id == id);
            if(obj == null) return NotFound();
            
            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
