using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Parser.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class MetDataController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MetDataController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetCompanies()
        {

            var companies = _repository.MetData.GetAllData(trackChanges: false);
            var companiesDto = _mapper.Map<IEnumerable<MetDataDTO>>(companies);


            return Ok(companiesDto);


        }

        [HttpGet("{id}")]
        public IActionResult GetCompany(Guid id)
        {
            var company = _repository.MetData.GetData(id, trackChanges: false);
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
