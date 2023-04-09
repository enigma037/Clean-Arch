using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryService : IBaseService
    {
        public Task<int> CreateAsync<T>(T item, CancellationToken cancellation) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
