using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProjectDbContext _ctx;

        public ProductRepository(ProjectDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Product product)
        {
            _ctx.Products.Add(product);
            _ctx.SaveChanges();
        }

        public IQueryable<Product> GetProducts()
        {
            return _ctx.Products;
        }
    }
}
