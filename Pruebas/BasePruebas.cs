using LionDev;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class BasePruebas
    {
        protected ApplicationDbContext ConstruirContext(string nombreDB)
        { 
            var opciones= new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(nombreDB).Options;
            var dbContext = new ApplicationDbContext(opciones);
            return dbContext;
        }

        protected IConfiguration ConstruirConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>())
                .Build();

            return configuration;
        }
    }
}
