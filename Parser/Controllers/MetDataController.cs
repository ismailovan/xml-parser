using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Parser.Controllers
{
    

    [Route("api/metData")]
    [ApiController]
    public class MetDataController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public  MetDataController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMetData(string? search = "")
        {
            
            if (search == "")
            {
                var companies = await _repository.MetData.GetAllMetDataAsync(trackChanges: false);
                var companiesDto = _mapper.Map<IEnumerable<MetDataDTO>>(companies);
                return Ok(companiesDto);
            }
            else
            {
                var companies_s = await _repository.MetData.GetAllMetDataAsync(trackChanges: false);
                var company = companies_s.Where(x => x.domain_title.Contains(search.ToUpper())).OrderBy(t => t.Id).Last();
                var companyDto = _mapper.Map<MetDataDTO>(company);
                return Ok(companyDto);

            }
            


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMetData(int id)
        {
            var company = await _repository.MetData.GetMetDataAsync(id, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var companyDto = _mapper.Map<MetDataDTO>(company);
                return Ok(companyDto);
            }
        }
    }
}
