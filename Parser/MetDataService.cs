
using Contracts;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
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
                    domain_lat = node["domain_lat"].InnerText,
                    domain_altitude = node["domain_altitude"].InnerText,
                    domain_lon = node["domain_lon"].InnerText,
                    dataSource_title = node["dataSource_title"].InnerText,
                    tsValid_issued = node["tsValid_issued"].InnerText,
                    tsValid_issued_day = node["tsValid_issued_day"].InnerText,
                    tsValid_issued_RFC822 = node["tsValid_issued_RFC822"].InnerText,
                    tsValid_issued_UTC = node["tsValid_issued_UTC"].InnerText,
                    tsUpdated = node["tsUpdated"].InnerText,
                    tsUpdated_day = node["tsUpdated_day"].InnerText,
                    tsUpdated_UTC = node["tsUpdated_UTC"].InnerText,
                    valid_day = node["valid_day"].InnerText,
                    validStart = node["validStart"].InnerText,
                    validEnd = node["validEnd"].InnerText,
                    valid = node["valid"].InnerText,
                    valid_UTC = node["valid_UTC"].InnerText,
                    nn_var_desc = node["nn_var_desc"].InnerText,
                    wwsyn_var_desc = node["wwsyn_var_desc"].InnerText,
                    t_var_desc = node["t_var_desc"].InnerText,
                    t_var_unit = node["t_var_unit"].InnerText,
                    t = node["t"].InnerText,
                    t_state = node["t_state"].InnerText,
                    td_var_desc = node["td_var_desc"].InnerText,
                    td_var_unit = node["td_var_unit"].InnerText,
                    td = node["td"].InnerText,
                    td_state = node["td_state"].InnerText,
                    tavg_var_desc = node["tavg_var_desc"].InnerText,
                    tavg_var_unit = node["tavg_var_unit"].InnerText,
                    tavg = node["tavg"].InnerText,
                    tavg_state = node["tavg_state"].InnerText,
                    tx_var_desc = node["tx_var_desc"].InnerText,
                    tx_var_unit = node["tx_var_unit"].InnerText,
                    tn_var_desc = node["tn_var_desc"].InnerText,
                    tn_var_unit = node["tn_var_unit"].InnerText,
                    rh_var_desc = node["rh_var_desc"].InnerText,
                    rh_var_unit = node["rh_var_unit"].InnerText,
                    rh = node["rh"].InnerText,
                    rh_state = node["rh_state"].InnerText,
                    rhavg_var_desc = node["rhavg_var_desc"].InnerText,
                    rhavg_var_unit = node["rhavg_var_unit"].InnerText,
                    rhavg = node["rhavg"].InnerText,
                    rhavg_state = node["rhavg_state"].InnerText,
                    dd_var_desc = node["dd_var_desc"].InnerText,
                    dd_var_unit = node["dd_var_unit"].InnerText,
                    ddavg_var_desc = node["ddavg_var_desc"].InnerText,
                    ddavg_var_unit = node["ddavg_var_unit"].InnerText,
                    ddmax_var_desc = node["ddmax_var_desc"].InnerText,
                    ddmax_var_unit = node["ddmax_var_unit"].InnerText,
                    ff_var_desc = node["ff_var_desc"].InnerText,
                    ff_var_unit = node["ff_var_unit"].InnerText,
                    ffavg_var_desc = node["ffavg_var_desc"].InnerText,
                    ffavg_var_unit = node["ffavg_var_unit"].InnerText,
                    ffmax_var_desc = node["ffmax_var_desc"].InnerText,
                    ffmax_var_unit = node["ffmax_var_unit"].InnerText,
                    msl_var_desc = node["msl_var_desc"].InnerText,
                    msl_var_unit = node["msl_var_unit"].InnerText,
                    mslavg_var_desc = node["mslavg_var_desc"].InnerText,
                    mslavg_var_unit = node["mslavg_var_unit"].InnerText,
                    p_var_desc = node["p_var_desc"].InnerText,
                    p_var_unit = node["p_var_unit"].InnerText,
                    pavg_var_desc = node["pavg_var_desc"].InnerText,
                    pavg_var_unit = node["pavg_var_unit"].InnerText,
                    rr_var_desc = node["rr_var_desc"].InnerText,
                    rr_var_unit = node["rr_var_unit"].InnerText,
                    rr_val = node["rr_val"].InnerText,
                    rr_state = node["rr_state"].InnerText,
                    snow_var_desc = node["snow_var_desc"].InnerText,
                    snow_var_unit = node["snow_var_unit"].InnerText,
                    snow = node["snow"].InnerText,
                    snow_state = node["snow_state"].InnerText,
                    tp_1h_acc_var_desc = node["tp_1h_acc_var_desc"].InnerText,
                    tp_1h_acc_var_unit = node["tp_1h_acc_var_unit"].InnerText,
                    tp_12h_acc_var_desc = node["tp_12h_acc_var_desc"].InnerText,
                    tp_12h_acc_var_unit = node["tp_12h_acc_var_unit"].InnerText,
                    tp_12h_acc = node["tp_12h_acc"].InnerText,
                    tp_12h_acc_state = node["tp_12h_acc_state"].InnerText,
                    tp_24h_acc_var_desc = node["tp_24h_acc_var_desc"].InnerText,
                    tp_24h_acc_var_unit = node["tp_24h_acc_var_unit"].InnerText,
                    tw_var_desc = node["tw_var_desc"].InnerText,
                    tw_var_unit = node["tw_var_unit"].InnerText,
                    gSunRad_var_desc = node["gSunRad_var_desc"].InnerText,
                    gSunRad_var_unit = node["gSunRad_var_unit"].InnerText,
                    gSunRadavg_var_desc = node["gSunRadavg_var_desc"].InnerText,
                    gSunRadavg_var_unit = node["gSunRadavg_var_unit"].InnerText,
                    diffSunRad_var_desc = node["diffSunRad_var_desc"].InnerText,
                    diffSunRad_var_unit = node["diffSunRad_var_unit"].InnerText,
                    diffSunRadavg_var_desc = node["diffSunRadavg_var_desc"].InnerText,
                    diffSunRadavg_var_unit = node["diffSunRadavg_var_unit"].InnerText,
                    vis_desc = node["vis_desc"].InnerText,
                    vis_unit = node["vis_unit"].InnerText,
                    t_5_cm_var_desc = node["t_5_cm_var_desc"].InnerText,
                    t_5_cm_var_unit = node["t_5_cm_var_unit"].InnerText,
                    tavg_5_cm_var_desc = node["tavg_5_cm_var_desc"].InnerText,
                    tavg_5_cm_var_unit = node["tavg_5_cm_var_unit"].InnerText,
                    tg_5_cm_var_desc = node["tg_5_cm_var_desc"].InnerText,
                    tg_5_cm_var_unit = node["tg_5_cm_var_unit"].InnerText,
                    tgavg_5_cm_var_desc = node["tgavg_5_cm_var_desc"].InnerText,
                    tgavg_5_cm_var_unit = node["tgavg_5_cm_var_unit"].InnerText,
                    tg_10_cm_var_desc = node["tg_10_cm_var_desc"].InnerText,
                    tg_10_cm_var_unit = node["tg_10_cm_var_unit"].InnerText,
                    tgavg_10_cm_var_desc = node["tgavg_10_cm_var_desc"].InnerText,
                    tgavg_10_cm_var_unit = node["tgavg_10_cm_var_unit"].InnerText,
                    tg_20_cm_var_desc = node["tg_20_cm_var_desc"].InnerText,
                    tg_20_cm_var_unit = node["tg_20_cm_var_unit"].InnerText,
                    tgavg_20_cm_var_desc = node["tgavg_20_cm_var_desc"].InnerText,
                    tgavg_20_cm_var_unit = node["tgavg_20_cm_var_unit"].InnerText,
                    tg_30_cm_var_desc = node["tg_30_cm_var_desc"].InnerText,
                    tg_30_cm_var_unit = node["tg_30_cm_var_unit"].InnerText,
                    tgavg_30_cm_var_desc = node["tgavg_30_cm_var_desc"].InnerText,
                    tgavg_30_cm_var_unit = node["tgavg_30_cm_var_unit"].InnerText,
                    tg_50_cm_var_desc = node["tg_50_cm_var_desc"].InnerText,
                    tg_50_cm_var_unit = node["tg_50_cm_var_unit"].InnerText,
                    tgavg_50_cm_var_desc = node["tgavg_50_cm_var_desc"].InnerText,
                    tgavg_50_cm_var_unit = node["tgavg_50_cm_var_unit"].InnerText,
                    hhs_var_desc = node["hhs_var_desc"].InnerText,
                    hhs_var_unit = node["hhs_var_unit"].InnerText,
                    ns_var_desc = node["ns_var_desc"].InnerText,
                    ns_var_unit = node["ns_var_unit"].InnerText,


                });
            }

            var result = await EqualizeUsers(data);
            _logger.LogInfo("Ending process of parsing XML");

            return result;
        }
        public virtual async Task<bool> EqualizeUsers(List<MetDataXml> xmlData)
        {

            //all existed data
            var md = await _repository.MetData.GetAllMetDataAsync(trackChanges: false);
            //take only new data to database
             xmlData.RemoveAll(x => md.Any(y => y.domain_title == x.domain_title && y.tsUpdated_RFC822 == x.tsUpdated_RFC822));
            if (!xmlData.Any())
            {
                _logger.LogInfo($"No any new meta data");
                return false;
            }
            else
            {
                _logger.LogInfo($"Found {xmlData.Count} new meta data");
                return await SaveNewData(xmlData);
            }

        }

public virtual async Task<bool> SaveNewData(List<MetDataXml> newData)
        {
            try
            {
                _logger.LogInfo("Saving new users");


                var newMetDataEntity = newData.Select(x => new MetData
                {
                    domain_title = x.domain_title,
                    domain_meteosiId = x.domain_meteosiId,
                    domain_longTitle = x.domain_longTitle,
                    domain_shortTitle = x.domain_shortTitle,
                    sunset = x.sunset,
                    sunrise = x.sunrise,
                    tsUpdated_RFC822 = x.tsUpdated_RFC822,
                    domain_lat = x.domain_lat,
                    domain_altitude = x.domain_altitude,
                    domain_lon = x.domain_lon,
                    dataSource_title = x.dataSource_title,
                    tsValid_issued = x.tsValid_issued,
                    tsValid_issued_day = x.tsValid_issued_day,
                    tsValid_issued_RFC822 = x.tsValid_issued_RFC822,
                    tsValid_issued_UTC = x.tsValid_issued_UTC,
                    tsUpdated = x.tsUpdated,
                    tsUpdated_day = x.tsUpdated_day,
                    tsUpdated_UTC = x.tsUpdated_UTC,
                    valid_day = x.valid_day,
                    validStart = x.validStart,
                    validEnd = x.validEnd,
                    valid = x.valid,
                    valid_UTC = x.valid_UTC,
                    nn_var_desc = x.nn_var_desc,
                    wwsyn_var_desc = x.wwsyn_var_desc,
                    t_var_desc = x.t_var_desc,
                    t_var_unit = x.t_var_unit,
                    t = x.t,
                    t_state = x.t_state,
                    td_var_desc = x.td_var_desc,
                    td_var_unit = x.td_var_unit,
                    td = x.td,
                    td_state = x.td_state,
                    tavg_var_desc = x.tavg_var_desc,
                    tavg_var_unit = x.tavg_var_unit,
                    tavg = x.tavg,
                    tavg_state = x.tavg_state,
                    tx_var_desc = x.tx_var_desc,
                    tx_var_unit = x.tx_var_unit,
                    tn_var_desc = x.tn_var_desc,
                    tn_var_unit = x.tn_var_unit,
                    rh_var_desc = x.rh_var_desc,
                    rh_var_unit = x.rh_var_unit,
                    rh = x.rh,
                    rh_state = x.rh_state,
                    rhavg_var_desc = x.rhavg_var_desc,
                    rhavg_var_unit = x.rhavg_var_unit,
                    rhavg = x.rhavg,
                    rhavg_state = x.rhavg_state,
                    dd_var_desc = x.dd_var_desc,
                    dd_var_unit = x.dd_var_unit,
                    ddavg_var_desc = x.ddavg_var_desc,
                    ddavg_var_unit = x.ddavg_var_unit,
                    ddmax_var_desc = x.ddmax_var_desc,
                    ddmax_var_unit = x.ddmax_var_unit,
                    ff_var_desc = x.ff_var_desc,
                    ff_var_unit = x.ff_var_unit,
                    ffavg_var_desc = x.ffavg_var_desc,
                    ffavg_var_unit = x.ffavg_var_unit,
                    ffmax_var_desc = x.ffmax_var_desc,
                    ffmax_var_unit = x.ffmax_var_unit,
                    msl_var_desc = x.msl_var_desc,
                    msl_var_unit = x.msl_var_unit,
                    mslavg_var_desc = x.mslavg_var_desc,
                    mslavg_var_unit = x.mslavg_var_unit,
                    p_var_desc = x.p_var_desc,
                    p_var_unit = x.p_var_unit,
                    pavg_var_desc = x.pavg_var_desc,
                    pavg_var_unit = x.pavg_var_unit,
                    rr_var_desc = x.rr_var_desc,
                    rr_var_unit = x.rr_var_unit,
                    rr_val = x.rr_val,
                    rr_state = x.rr_state,
                    snow_var_desc = x.snow_var_desc,
                    snow_var_unit = x.snow_var_unit,
                    snow = x.snow,
                    snow_state = x.snow_state,
                    tp_1h_acc_var_desc = x.tp_1h_acc_var_desc,
                    tp_1h_acc_var_unit = x.tp_1h_acc_var_unit,
                    tp_12h_acc_var_desc = x.tp_12h_acc_var_desc,
                    tp_12h_acc_var_unit = x.tp_12h_acc_var_unit,
                    tp_12h_acc = x.tp_12h_acc,
                    tp_12h_acc_state = x.tp_12h_acc_state,
                    tp_24h_acc_var_desc = x.tp_24h_acc_var_desc,
                    tp_24h_acc_var_unit = x.tp_24h_acc_var_unit,
                    tw_var_desc = x.tw_var_desc,
                    tw_var_unit = x.tw_var_unit,
                    gSunRad_var_desc = x.gSunRad_var_desc,
                    gSunRad_var_unit = x.gSunRad_var_unit,
                    gSunRadavg_var_desc = x.gSunRadavg_var_desc,
                    gSunRadavg_var_unit = x.gSunRadavg_var_unit,
                    diffSunRad_var_desc = x.diffSunRad_var_desc,
                    diffSunRad_var_unit = x.diffSunRad_var_unit,
                    diffSunRadavg_var_desc = x.diffSunRadavg_var_desc,
                    diffSunRadavg_var_unit = x.diffSunRadavg_var_unit,
                    vis_desc = x.vis_desc,
                    vis_unit = x.vis_unit,
                    t_5_cm_var_desc = x.t_5_cm_var_desc,
                    t_5_cm_var_unit = x.t_5_cm_var_unit,
                    tavg_5_cm_var_desc = x.tavg_5_cm_var_desc,
                    tavg_5_cm_var_unit = x.tavg_5_cm_var_unit,
                    tg_5_cm_var_desc = x.tg_5_cm_var_desc,
                    tg_5_cm_var_unit = x.tg_5_cm_var_unit,
                    tgavg_5_cm_var_desc = x.tgavg_5_cm_var_desc,
                    tgavg_5_cm_var_unit = x.tgavg_5_cm_var_unit,
                    tg_10_cm_var_desc = x.tg_10_cm_var_desc,
                    tg_10_cm_var_unit = x.tg_10_cm_var_unit,
                    tgavg_10_cm_var_desc = x.tgavg_10_cm_var_desc,
                    tgavg_10_cm_var_unit = x.tgavg_10_cm_var_unit,
                    tg_20_cm_var_desc = x.tg_20_cm_var_desc,
                    tg_20_cm_var_unit = x.tg_20_cm_var_unit,
                    tgavg_20_cm_var_desc = x.tgavg_20_cm_var_desc,
                    tgavg_20_cm_var_unit = x.tgavg_20_cm_var_unit,
                    tg_30_cm_var_desc = x.tg_30_cm_var_desc,
                    tg_30_cm_var_unit = x.tg_30_cm_var_unit,
                    tgavg_30_cm_var_desc = x.tgavg_30_cm_var_desc,
                    tgavg_30_cm_var_unit = x.tgavg_30_cm_var_unit,
                    tg_50_cm_var_desc = x.tg_50_cm_var_desc,
                    tg_50_cm_var_unit = x.tg_50_cm_var_unit,
                    tgavg_50_cm_var_desc = x.tgavg_50_cm_var_desc,
                    tgavg_50_cm_var_unit = x.tgavg_50_cm_var_unit,
                    hhs_var_desc = x.hhs_var_desc,
                    hhs_var_unit = x.hhs_var_unit,
                    ns_var_desc = x.ns_var_desc,
                    ns_var_unit = x.ns_var_unit,


                }).ToList();
                
                _repository.MetData.CreateBulk(newMetDataEntity);
                await _repository.SaveAsync();

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
