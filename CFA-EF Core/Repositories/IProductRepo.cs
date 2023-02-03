using CFA_EF_Core.Models;

namespace CFA_EF_Core.Repositories
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductDetail(int id);
        Product EditProduct(Product p);
        Product DeleteProduct(int id);
    }
}
