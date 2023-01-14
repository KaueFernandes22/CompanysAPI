using CompanysAPI.Intefaces;
using CompanysAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanysAPI.Controllers
{

    [Route("companies")]
    [ApiController]
    public class CompanysController : ControllerBase
    {

        private readonly ICompanyRepository _companyRepository;
        public CompanysController(ICompanyRepository companyRepository) 
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Company>> GetCompanys()
        {
            return await _companyRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompanys(int id) 
        {
            return await _companyRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Company>> PostCompanys([FromBody] Company company)
        {
            var  newCompany = await _companyRepository.Create(company);
            return CreatedAtAction(nameof(GetCompanys), new {id = newCompany.Id}, newCompany);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Company>> Delete(int id)
        {
            var companyToDelete = await _companyRepository.Get(id);

            if (companyToDelete == null)
            {
                return NotFound();
            }

            await _companyRepository.Delete(companyToDelete.Id);

            return NoContent();            
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> PutCompanys(int id, [FromBody] Company company)
        {
            if (id == company.Id)
            {
               return BadRequest();
            }

            await _companyRepository.Update(company);

            return NoContent();
        }
    }
}
