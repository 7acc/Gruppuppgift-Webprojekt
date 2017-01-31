using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL.Repositories
{
    public class ApartmentRepository
    {

        public List<Appartment> GetAll()
        {
            using (var ctx = new Webb4Context())
            {
                var list = ctx.Appartments.ToList();
                return list;
            }              
        }

      

        public void SaveAppartmentToDB(Appartment appartmentdata)
        {
            using (var ctx = new Webb4Context())
            {
                ctx.Appartments.Add(appartmentdata);
                ctx.SaveChanges();
            }
        }
    }
}
