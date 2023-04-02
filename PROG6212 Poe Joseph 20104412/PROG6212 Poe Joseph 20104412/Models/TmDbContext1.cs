using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PROG6212_Poe_Joseph_20104412.Models
{
    public class TmDbContext1: DbContext
    {
        public DbSet<Modules> moduleData { get; set; }

        public System.Data.Entity.DbSet<PROG6212_Poe_Joseph_20104412.Models.StudyHours> StudyHours { get; set; }
    }
}