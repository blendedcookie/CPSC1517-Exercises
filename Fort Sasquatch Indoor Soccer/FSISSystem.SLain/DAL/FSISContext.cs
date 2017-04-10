using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using System.Data.Entity;


namespace FSISSystem.SLain.DAL
{
    internal class FSISContext:DbContext
    {
        public FSISContext() : base("FSISdb")
        {

        }

        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}
