using Enzwals.api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Enzwals.api.Data
{
    public class Enzwalkdbcontext:DbContext
    {
        public Enzwalkdbcontext(DbContextOptions<Enzwalkdbcontext> options):base(options)
        {
           
        }
        public DbSet<Region> regions { get; set; }
        public DbSet<walk> walks { get;set; }
        public DbSet<wALK_difficulty> difficulties { get; set; }    



    }
}
