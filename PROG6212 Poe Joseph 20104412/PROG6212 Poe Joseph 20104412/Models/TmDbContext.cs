using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PROG6212_Poe_Joseph_20104412.Models
{
    public class TmDbContext : DbContext
    {
        //creating a new dataset property
        //Dbset: this is known as a dataset property...
        //It is used to represent in-memory cache of data and it stores data retrieved from the datasource (Microsoft, 2021).
        public DbSet<Student> studentsAccount { get; set; }
    }
}