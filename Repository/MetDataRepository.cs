using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
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

        public void CreateMetData(MetData metData) => Create(metData);

        public IEnumerable<MetData> GetAllData(bool trackChanges) =>
             FindAll(trackChanges)
             .OrderBy(c => c.domain_meteosiId)
             .ToList();

        public MetData GetData(Guid companyId, bool trackChanges) => FindByCondition(c => c.Id.Equals(companyId), trackChanges).SingleOrDefault();

        public void CreateBulk(List<MetData> metData) => CreatBulk(metData);
        
    }
}
