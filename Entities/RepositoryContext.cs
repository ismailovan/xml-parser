using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite("DataSource = LocalDatabase.db;");

        public DbSet<MetData> MetData { get; set; }
    }
}
