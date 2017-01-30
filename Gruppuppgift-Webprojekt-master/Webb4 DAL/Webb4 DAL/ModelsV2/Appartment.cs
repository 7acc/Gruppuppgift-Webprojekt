using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.ModelsV2
{
   public class Appartment
    {
        public Appartment()
        {
            this.Features = new HashSet<Features>();
            this.Photos = new HashSet<AppartmentPhoto>();
          
        }
        public int Id { get; set; }
        public int Area { get; set; }
        public int Rent { get; set; }
        public int NrOfRooms { get; set; }
        public int BuildinFloors { get; set; }
        public int Floor { get; set; }
        public DateTime BuildYear{ get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime LastAdmissionDate { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool Avalible { get; set; }


        public virtual Adress Adress { get; set; }
        public virtual HousingType Housing { get; set; }
        public virtual District District { get; set; }


        public virtual ICollection<Features> Features { get; set; }                     
        public virtual ICollection<AppartmentPhoto> Photos { get; set; }

        public virtual ICollection<User> UsersFollowing { get; set; }

    }
}
