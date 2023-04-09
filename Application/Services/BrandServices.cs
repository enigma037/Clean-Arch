using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BrandServices : IBrandServices, IBaseService
    {
        private readonly IEDbContext _dbContext;
        public BrandServices(IEDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync<T>(T item, CancellationToken cancellationToken) where T : class
        {
            var brand = item as Brand;
            if (brand != null)
            {
                _dbContext.Brands.Add(brand);
                await _dbContext.SaveChangesAsync(cancellationToken);
            }

            return brand.Id;
        }

        public Task<List<Brand>> ListBrandsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
