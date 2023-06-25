
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

namespace Parser
{
    public class MetDataService
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;
        

        public MetDataService(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public virtual async Task<bool> ExecuteService(CancellationToken stoppingToken)
        {
            _logger.LogInfo("Starting process");

            List<MetDataXml> data = new List<MetDataXml>();
            XmlDocument doc = new XmlDocument();
            doc.Load("https://meteo.arso.gov.si/uploads/probase/www/observ/surface/text/sl/observationAms_si_latest.xml");

            foreach (XmlNode node in doc.SelectNodes("/data/metData"))
            {
                
                data.Add(new MetDataXml
                {
                    domain_title = node["domain_title"].InnerText,
                    domain_shortTitle = node["domain_shortTitle"].InnerText,
                    domain_longTitle = node["domain_longTitle"].InnerText,
                    domain_meteosiId = node["domain_meteosiId"].InnerText,
                    sunrise = node["sunrise"].InnerText,
                    sunset = node["sunset"].InnerText,
                    tsUpdated_RFC822 = node["tsUpdated_RFC822"].InnerText,
                });
            }

            var result = await EqualizeUsers(data);
            _logger.LogInfo("Ending process of parsing XML");

            return result;
        }
        public virtual async Task<bool> EqualizeUsers(List<MetDataXml> xmlData)
        {

            //all existed data
            var md = _repository.MetData.GetAllData(trackChanges: false);
            //take only new data to database
            var newMetData = xmlData.Where(x => !md.Any(x1 => x1.domain_title != x.domain_title && x1.tsUpdated_RFC822 != x.tsUpdated_RFC822)).ToList();
            if (!newMetData.Any())
            {
                _logger.LogInfo($"No any new meta data");
                return false;
            }
            else
            {
                _logger.LogInfo($"Found {newMetData.Count} new meta data");
                return await SaveNewData(newMetData);
            }
            
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
                    sunset = x.sunset,
                    sunrise = x.sunrise,
                    tsUpdated_RFC822 = x.tsUpdated_RFC822


                }).ToList();
                
                _repository.MetData.CreateBulk(newUsersEntity);
                _repository.Save();

                _logger.LogInfo("New users successfully saved");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error saving new users - {ex.Message}");
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
