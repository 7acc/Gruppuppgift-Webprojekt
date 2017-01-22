using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Webb4_DAL.Models;

namespace Webb4_DAL
{
    public class Webb4Context : DbContext
    {
        public DbSet<AppartmentDataModel> AppartmentDataModels { get; set; }

    }

   
}
