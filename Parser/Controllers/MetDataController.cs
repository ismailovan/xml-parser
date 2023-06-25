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
        public IActionResult GetAllMetData()
        {

            var companies = _repository.MetData.GetAllData(trackChanges: false);
            var companiesDto = _mapper.Map<IEnumerable<MetDataDTO>>(companies);


            return Ok(companiesDto);


        }

        [HttpGet("{title}")]
        public IActionResult GetMetData(string title)
        {
            var company = _repository.MetData.GetData(title, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {title} doesn't exist in the database.");
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
