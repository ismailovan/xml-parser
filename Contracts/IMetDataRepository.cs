using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Contracts
{
    public interface IMetDataRepository 
    {
        void CreateMetData(Entities.Models.MetData metData);
        MetData GetData(Guid Id, bool trackChanges);
        IEnumerable<MetData> GetAllData( bool trackChanges);

        void CreateBulk(List<MetData> metData);


    }
}
