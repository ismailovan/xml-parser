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
        //void CreateMetData(MetData metData);
        //MetData GetData(string title, bool trackChanges);
        Task<MetData> GetMetDataAsync(int id, bool trackChanges);

        //IEnumerable<MetData> GetAllData( bool trackChanges);
        Task<IEnumerable<MetData>> GetAllMetDataAsync(bool trackChanges);
       
        void CreateBulk(List<MetData> metData);


    }
}
