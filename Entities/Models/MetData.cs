﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class MetData
    {
        
        public Guid Id { get; set; }
        public string domain_title { get; set; }
        public string domain_shortTitle { get; set; }    
        public string domain_longTitle { get; set; }
        public string domain_meteosiId { get; set; }
        
        
    }
}