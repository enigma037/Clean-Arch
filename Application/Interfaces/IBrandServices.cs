using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBrandServices
    {
        Task<List<Brand>> ListBrandsAsync(CancellationToken cancellationToken);
    }
}
