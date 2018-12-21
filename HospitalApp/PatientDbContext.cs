using HospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
  public   class PatientDbContext:DbContext
    {
        public PatientDbContext():
            base("DBConnection")
        {}

       public DbSet<Patient> Patients { get; set; }


    }
   

  
}
