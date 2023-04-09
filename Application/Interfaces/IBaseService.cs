using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBaseService
    {
        Task<int> CreateAsync<T>(T item, CancellationToken cancellation) where T : class;
    }
}
