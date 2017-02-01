
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels2.VyModels;
using Webb4_businesslayer.HelpMapper;
using System.Collections.Generic;
using System.Linq;

namespace Webb4___MVC.Controllers
{
    public class HomeController : Controller
    {
        private AppartmentMapping AppartmentMapping { get; set; }
        private AppartmentPhotoMapping AppartmentPhotoMapping { get; set; }
        private DistrictMapping DistrictMapping { get; set; }
        private FeaturesMapping FeaturesMapping { get; set; }
        private HousingTypeMapping HousingTypeMapping { get; set; }
        public UserMapping UserMapping { get; set; }
        public HomeController()
        {
            AppartmentMapping = new AppartmentMapping();
            AppartmentPhotoMapping = new AppartmentPhotoMapping();
            DistrictMapping = new DistrictMapping();
            FeaturesMapping = new FeaturesMapping();
            HousingTypeMapping = new HousingTypeMapping();
            UserMapping = new UserMapping();
        }

        public int convertrum(string instring)
            {
            int maxrent = 0;
            switch (instring)
                {
                case "Alla":
                    maxrent = 9999;
                    break;
                case "Ettor":
                    maxrent = 1;
                    break;
                case "Tvåor":
                    maxrent = 2;
                    break;
                case "Treor":
                    maxrent = 3;
                    break;
                case "Fyror":
                    maxrent = 4;
                    break;
                case "Femmor":
                    maxrent = 5;
                    break;
                case "Sexor":
                    maxrent = 6;
                    break;





                }

            return maxrent;



            }



        public int convertarea(string instring)
            {
            int maxrent = 0;
            switch (instring)
                {
                case "Alla":
                    maxrent = 9999;
                    break;
                case "30 kvm":
                    maxrent = 30;
                    break;
                case "40 kvm":
                    maxrent = 40;
                    break;
                case "50 kvm":
                    maxrent = 50;
                    break;
                case "60 kvm":
                    maxrent = 60;
                    break;
                case "70 kvm":
                    maxrent = 70;
                    break;
                case "80 kvm":
                    maxrent = 80;
                    break;
                case "90 kvm":
                    maxrent = 90;
                    break;
                case "100 kvm":
                    maxrent = 100;
                    break;





                }

            return maxrent;



            }



        public int convertrent(string instring)
            {
            int maxrent = 0;
            switch (instring)
                {
                case "Alla":
                    maxrent = 999999;
                    break;
                case "2000 kr":
                    maxrent = 2000;
                    break;
                case "3000 kr":
                    maxrent = 3000;
                    break;
                case "4000 kr":
                    maxrent = 4000;
                    break;
                case "5000 kr":
                    maxrent = 5000;
                    break;
                case "6000 kr":
                    maxrent = 6000;
                    break;
                case "7000 kr":
                    maxrent = 7000;
                    break;
                case "8000 kr":
                    maxrent = 8000;
                    break;
                case "10000 kr":
                    maxrent = 10000;
                    break;
                case "12000 kr":
                    maxrent = 12000;
                    break;
                case "15000 kr":
                    maxrent = 15000;
                    break;
                case "20000 kr":
                    maxrent = 20000;
                    break;





                }

            return maxrent;



            }


        public ActionResult Find(string Omrade, string Boform, string Rum, string MaxHyra, string Minyta, string Maxyta, string Sort)
            {
            var g = AppartmentMapping.FromBltoUiGetAll();

            string sortname;
            int antalrum = convertrum(Rum);
            int maxrent = convertrent(MaxHyra);
            int minarea = convertarea(Minyta);
            if (minarea > 1000)
                minarea = 0;
            int maxarea = convertarea(Maxyta);



            switch (Sort)
                {
                case "Publiceringsdatum":
                    sortname = "PublicationDate";
                    break;
                case "Antal Intresseanmälningar":
                    sortname = "UsersFollowing.Count";
                    break;
                case "Adress":
                    sortname = "Adress.Street";
                    break;
                case "Hyra":
                    sortname = "Rent";
                    break;
                case "Inflyttning":
                    sortname = "MoveInDate";
                    break;
                case "Område":
                    sortname = "District.Name";
                    break;
                case "Antal rum":
                    sortname = "NrofRooms";
                    break;
                case "Yta":
                    sortname = "Area";
                    break;


                default:
                    break;
                }


            if (Omrade == "Alla" && Boform == "Alla" && Rum == "Alla" && MaxHyra=="Alla" && Minyta=="Alla" && Maxyta=="Alla")
                {

                return View("_apartments1", g);

                }
            else


            if (Omrade == "Alla" && Boform == "Alla" && Rum == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            else
            if (Omrade == "Alla" && Boform == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.NrOfRooms == antalrum && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            else
            if (Omrade == "Alla" && Rum == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.Housing.Type == Boform && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            if (Rum == "Alla" && Boform == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.District.Name == Omrade && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            else
                if (Omrade == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.NrOfRooms == antalrum && p.Housing.Type == Boform && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            else
            if (Rum == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.Housing.Type == Boform && p.District.Name == Omrade && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            else
            if (Boform == "Alla")
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.NrOfRooms == antalrum && p.District.Name == Omrade && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }
            else
                {
                var r2 = from p in g where (p.Area >= minarea && p.Area < maxarea && p.NrOfRooms == antalrum && p.Housing.Type == Boform && p.District.Name == Omrade && p.Rent <= maxrent) select p;
                return View("_apartments1", r2);

                }


            //return View("_apartments1", g.ToList());



            }


        // GET: Home
        public ActionResult Index()
        {
            var g = AppartmentMapping.FromBltoUiGetAll();
            return View();
        }


        // GET: /Apartment/Details
        public ActionResult ListOfApartments( )
        {
            var g = AppartmentMapping.FromBltoUiGetAll();
            return View(g);
        }

        // GET: /Apartment/Details
        public /*async Task<ActionResult>*/ ActionResult Details(int id)
        {
            var r = /*await*/ AppartmentMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //
        // GET: /UserData/Details/5
        public async Task<ActionResult> UserDetails(int id)
        {
            var r = await UserMapping.FromBltoUiGetById(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // GET: /UserData/Apartments // Alltså hämta en list av lägenheter som en user har gjort intresse för.
        public ActionResult InterestApartment (int id)
        {
            //var ListOfUsers = AppartmentMapping.FromBltoUiGetAllUserInterestApartment(id);

            return View(/*ListOfUsers*/);
        }
    }
}