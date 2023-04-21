using DemoSession2_WebAPI.Models;

namespace DemoSession2_WebAPI.Services;

public interface ProductServices
{
    public List<Product> FindAll();
    public dynamic findAll2();
}
