using System;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;

namespace Bulky.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDBContext _db;
    public ICategoryRepository Category {get; private set;}
    public UnitOfWork(ApplicationDBContext db)
    {
        _db = db;
        Category = new CategoryRepository(_db);

    }

    public void Save()
    {
        _db.SaveChanges();
    }
}
