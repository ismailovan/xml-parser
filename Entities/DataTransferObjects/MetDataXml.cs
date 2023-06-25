using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class MetDataXml
    {
        public string domain_title { get; set; }
        public string domain_shortTitle { get; set; }
        public string domain_longTitle { get; set; }
        public string domain_meteosiId { get; set; }
        public string sunrise { get; set; } // timestamp
        public string sunset { get; set; } // timestamp
        public string tsUpdated_RFC822 { get; set; }
        public string domain_lat { get; set; }
        public string domain_lon { get; set; }
        public string domain_altitude { get; set; }
        public string dataSource_title { get; set; }

        public string tsValid_issued { get; set; }
        public string tsValid_issued_day { get; set; }
        public string tsValid_issued_UTC { get; set; }
        public string tsValid_issued_RFC822 { get; set; }
        public string tsUpdated { get; set; }
        public string tsUpdated_day { get; set; }
        public string tsUpdated_UTC { get; set; }

        public string valid_day { get; set; }
        public string valid { get; set; }
        public string valid_UTC { get; set; }
        public string validStart { get; set; }
        public string validEnd { get; set; }
        public string nn_var_desc { get; set; }
        public string wwsyn_var_desc { get; set; }
        public string t_var_desc { get; set; }
        public string t_var_unit { get; set; }

        public string t { get; set; }
        public string t_state { get; set; }
        public string td_var_desc { get; set; }
        public string td_var_unit { get; set; }
        public string td { get; set; }
        public string td_state { get; set; }
        public string tavg_var_desc { get; set; }
        public string tavg_var_unit { get; set; }
        public string tavg { get; set; }
        public string tavg_state { get; set; }
        public string tx_var_desc { get; set; }
        public string tx_var_unit { get; set; }
        public string tn_var_desc { get; set; }
        public string tn_var_unit { get; set; }
        public string rh_var_desc { get; set; }
        public string rh_var_unit { get; set; }
        public string rh { get; set; }
        public string rh_state { get; set; }
        public string rhavg_var_desc { get; set; }
        public string rhavg_var_unit { get; set; }
        public string rhavg { get; set; }
        public string rhavg_state { get; set; }
        public string dd_var_desc { get; set; }
        public string dd_var_unit { get; set; }
        public string ddavg_var_desc { get; set; }
        public string ddavg_var_unit { get; set; }
        public string ddmax_var_desc { get; set; }
        public string ddmax_var_unit { get; set; }
        public string ff_var_desc { get; set; }
        public string ff_var_unit { get; set; }
        public string ffavg_var_desc { get; set; }
        public string ffavg_var_unit { get; set; }
        public string ffmax_var_desc { get; set; }
        public string ffmax_var_unit { get; set; }
        public string msl_var_desc { get; set; }
        public string msl_var_unit { get; set; }
        public string mslavg_var_desc { get; set; }
        public string mslavg_var_unit { get; set; }
        public string p_var_desc { get; set; }

        public string p_var_unit { get; set; }
        public string pavg_var_desc { get; set; }
        public string pavg_var_unit { get; set; }
        public string rr_var_desc { get; set; }
        public string rr_var_unit { get; set; }

        public string rr_val { get; set; }
        public string rr_state { get; set; }
        public string snow_var_desc { get; set; }
        public string snow_var_unit { get; set; }
        public string snow { get; set; }
        public string snow_state { get; set; }
        public string tp_1h_acc_var_desc { get; set; }
        public string tp_1h_acc_var_unit { get; set; }
        public string tp_12h_acc_var_desc { get; set; }
        public string tp_12h_acc_var_unit { get; set; }
        public string tp_12h_acc { get; set; }
        public string tp_12h_acc_state { get; set; }
        public string tp_24h_acc_var_desc { get; set; }
        public string tp_24h_acc_var_unit { get; set; }
        public string tw_var_desc { get; set; }
        public string tw_var_unit { get; set; }
        public string gSunRad_var_desc { get; set; }
        public string gSunRad_var_unit { get; set; }
        public string gSunRadavg_var_desc { get; set; }
        public string gSunRadavg_var_unit { get; set; }
        public string diffSunRad_var_desc { get; set; }
        public string diffSunRad_var_unit { get; set; }
        public string diffSunRadavg_var_desc { get; set; }
        public string diffSunRadavg_var_unit { get; set; }
        public string vis_desc { get; set; }
        public string vis_unit { get; set; }
        public string t_5_cm_var_desc { get; set; }
        public string t_5_cm_var_unit { get; set; }
        public string tavg_5_cm_var_desc { get; set; }
        public string tavg_5_cm_var_unit { get; set; }
        public string tg_5_cm_var_desc { get; set; }
        public string tg_5_cm_var_unit { get; set; }
        public string tgavg_5_cm_var_desc { get; set; }
        public string tgavg_5_cm_var_unit { get; set; }
        public string tg_10_cm_var_desc { get; set; }
        public string tg_10_cm_var_unit { get; set; }
        public string tgavg_10_cm_var_desc { get; set; }
        public string tgavg_10_cm_var_unit { get; set; }
        public string tg_20_cm_var_desc { get; set; }
        public string tg_20_cm_var_unit { get; set; }
        public string tgavg_20_cm_var_desc { get; set; }
        public string tgavg_20_cm_var_unit { get; set; }
        public string tg_30_cm_var_desc { get; set; }
        public string tg_30_cm_var_unit { get; set; }
        public string tgavg_30_cm_var_desc { get; set; }
        public string tgavg_30_cm_var_unit { get; set; }
        public string tg_50_cm_var_desc { get; set; }
        public string tg_50_cm_var_unit { get; set; }
        public string tgavg_50_cm_var_desc { get; set; }
        public string tgavg_50_cm_var_unit { get; set; }
        public string hhs_var_desc { get; set; }
        public string hhs_var_unit { get; set; }
        public string ns_var_desc { get; set; }
        public string ns_var_unit { get; set; }


    }
}
