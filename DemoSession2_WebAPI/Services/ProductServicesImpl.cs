using DemoSession2_WebAPI.Models;

namespace DemoSession2_WebAPI.Services;

public class ProductServicesImpl : ProductServices
{
    private DatabaseContext db;
    public ProductServicesImpl(DatabaseContext _db) { this.db = _db; }

    public List<Product> FindAll()
    {   
        return db.Products.ToList();
    }

    public dynamic findAll2()
    {
        return db.Products.Select(product => new
        {
            id = product.Id,
            name=product.Name,
            price=product.Price,
            quantity = product.Quantity,
            status= product.Status,
            created= product.Created,
            descriptiom= product.Description,
        }).ToList();
    }
}
