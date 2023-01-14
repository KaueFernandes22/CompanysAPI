using CompanysAPI.Contexts;
using CompanysAPI.Intefaces;
using CompanysAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanysAPI.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public readonly DatabaseContext _context;
        public CompanyRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Company> Create(Company company)
        {
            _context.Companys.Add(company);
            await _context.SaveChangesAsync();

            return company;
        }

        public async Task Delete(int id)
        {
            var companyToDelete = await _context.Companys.FindAsync(id);
            _context.Companys.Remove(companyToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Company>> Get()
        {
            return await _context.Companys.ToListAsync();
        }

        public async Task<Company> Get(int id)
        {
            return await _context.Companys.FindAsync(id);
        }

        public async Task Update(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
