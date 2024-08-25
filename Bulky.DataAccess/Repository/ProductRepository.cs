using System;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repository;

public class ProductRepository(ApplicationDBContext db) : Repository<Product>(db), IProductRepository
{
    private readonly ApplicationDBContext _db = db;

    public void Update(Product obj)
    {
        _db.Products.Update(obj);
    }
}
