using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repository;

public class CategoryRepository(ApplicationDBContext db) : Repository<Category>(db), ICategoryRepository
{
    private readonly ApplicationDBContext _db = db;

    public void Update(Category obj)
    {
        _db.Categories.Update(obj);
    }
}
