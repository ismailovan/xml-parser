using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IMetDataRepository _metDataRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public IMetDataRepository MetData
        {
            get
            {
                if (_metDataRepository == null)
                    _metDataRepository = new MetDataRepository(_repositoryContext);
                return _metDataRepository;
            }
        }
        
        public void Save() => _repositoryContext.SaveChanges();
    }
}
