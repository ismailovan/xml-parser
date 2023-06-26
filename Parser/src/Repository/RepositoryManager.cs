using Contracts;
using Entities;
using Microsoft.Extensions.DependencyInjection;
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

        public RepositoryManager(IServiceProvider serviceProvider)
        {
            _repositoryContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<RepositoryContext>();
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

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
