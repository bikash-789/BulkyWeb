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
    }
}
