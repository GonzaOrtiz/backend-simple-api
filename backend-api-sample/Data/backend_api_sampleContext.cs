using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend_api_sample.Models;

namespace backend_api_sample.Data
{
    public class backend_api_sampleContext : DbContext
    {
        public backend_api_sampleContext (DbContextOptions<backend_api_sampleContext> options)
            : base(options)
        {
        }

        public DbSet<backend_api_sample.Models.Persona> Persona { get; set; }
    }
}
