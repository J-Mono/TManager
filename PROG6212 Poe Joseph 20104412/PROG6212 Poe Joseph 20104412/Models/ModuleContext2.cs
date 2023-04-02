using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PROG6212_Poe_Joseph_20104412.Models
{
    public class ModuleContext2 : DbContext
    {
        //Creating a new dataset property
        //Dbset: this is known as a dataset property...
        //It is used to represent in-memory cache of data and it stores data retrieved from the datasource (Microsoft, 2021).
        public DbSet<Modules> moduleData { get; set; }
    }
}