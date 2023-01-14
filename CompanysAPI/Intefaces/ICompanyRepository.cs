using CompanysAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanysAPI.Intefaces
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> Get();

        Task<Company> Get(int Id);

        Task<Company> Create(Company company);

        Task Update(Company company);

        Task Delete(int Id);
    }
}
