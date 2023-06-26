using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class MetDataRepository : RepositoryBase<MetData>, IMetDataRepository
    {
        public MetDataRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateBulk(List<MetData> metData) => CreatBulk(metData);

        public async Task<MetData> GetMetDataAsync(int id, bool trackChanges) => await FindByCondition(c => c.Id == id, trackChanges).SingleOrDefaultAsync();
        public async Task<IEnumerable<MetData>> GetAllMetDataAsync(bool trackChanges) => await FindAll(trackChanges).OrderBy(c => c.domain_title).ToListAsync();


        


    }
}
