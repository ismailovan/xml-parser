using AutoMapper;
using Contracts;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WorkerXML.Services
{
    public class MetDataService
    {
        private readonly ILoggerManager _logger;
        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;

        public MetDataService(ILoggerManager logger, RepositoryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
        }

        public virtual async Task<bool> ExecuteService(CancellationToken stoppingToken)
        {
            _logger.LogInfo("Starting process");

            List<MetDataXml> data = new List<MetDataXml>();
            XmlDocument doc = new XmlDocument();
            doc.Load("https://meteo.arso.gov.si/uploads/probase/www/observ/surface/text/sl/observationAms_si_latest.xml ");

            foreach (XmlNode node in doc.SelectNodes("/data/metData"))
            {

                data.Add(new MetDataXml
                {
                    domain_title = node["domain_title"].InnerText,
                    domain_shortTitle = node["domain_shortTitle"].InnerText,
                    domain_longTitle = node["domain_longTitle"].InnerText,
                    domain_meteosiId = node["domain_meteosiId"].InnerText,
                });
            }



            _logger.LogInfo("Ending process");



            var result = await EqualizeUsers(data);


            return result;
        }
        public virtual async Task<bool> EqualizeUsers(List<MetDataXml> xmlData)
        {
            
            //TO-DO check if metData already exists


            _logger.LogInfo($"Found {xmlData.Count} new meta data");

            return await SaveNewData(xmlData);
        }

        public virtual async Task<bool> SaveNewData(List<MetDataXml> newData)
        {
            try
            {
                _logger.LogInfo("Saving new users");


                var newUsersEntity = newData.Select(x => new MetData
                {
                    domain_title = x.domain_title,
                    domain_meteosiId = x.domain_meteosiId,
                    domain_longTitle = x.domain_longTitle,
                    domain_shortTitle = x.domain_shortTitle,


                }).ToList();

                await _context.MetData.AddRangeAsync(newUsersEntity);
                await _context.SaveChangesAsync();

                _logger.LogInfo("New users successfully saved");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error saving new users - {ex.Message}");
                return false;
            }
        }
    }
}
