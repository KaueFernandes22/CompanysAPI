using CompanysAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanysAPI.Intefaces
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> Get();

        Task<Product> Get(int Id);

        Task<Product> Create(Product product);

        Task Update(Product product);

        Task Delete(int Id);

    }
}
