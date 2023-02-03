using CFA_EF_Core.Models;
using CFA_EF_Core.Repositories;

namespace CFA_EF_Core.Repositories
{
    public class ProductRepo:IProductRepo
    {
        private ProductContext _context;
        public ProductRepo(ProductContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var productList = _context.Products.ToList();
            return productList;
        }
        public Product GetProductDetail(int id)
        {
            Product product = _context.Products.Find(id);
            return product;
        }
        public Product EditProduct(Product p)
        {
            _context.Products.Update(p);
            _context.SaveChanges();
            return p;
        }

        public Product DeleteProduct(int id)
        {
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return product;
        }
    }
}
