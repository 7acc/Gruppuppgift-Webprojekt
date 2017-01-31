using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.ViewModels2;
using Webb4_DAL.Repositories;
using Webb4_DAL.ModelsV2;
using System.Web;

namespace Webb4_businesslayer
{
    public class AppartmentManager
    {
        private ApartmentRepository apartmentRepo { get; set; }
        private PhotoManager PhotoManager { get; set; }
        public AppartmentManager()
        {
            apartmentRepo = new ApartmentRepository();
        }

        public List<AppartmentViewModel> GetAppartmentList()
        {
            var list = apartmentRepo.GetAll();
            var viewList = list.Select(x => x.ApartmentToViewModel()).ToList();

            return viewList;

        }
        public void AddAppartmentWithPhotosToDB(AppartmentViewModel appartmentToAdd, IEnumerable<HttpPostedFileBase> photos)
        {

            var listOfPhotos = new List<AppartmentPhoto>();
            foreach (var photo in photos)
            {
                var photoData = new AppartmentPhoto() {
                    Name = new Guid()                 
                };

               string url = PhotoManager.SavePhotoToCataloge(photo, photoData.Name);// not implemented!!!! LAZY AS BITCH

                photoData.URL = url;
                
            }

            var appartmentdata = appartmentToAdd.ViewModelToAppartment();
            appartmentdata.Photos = listOfPhotos;

            apartmentRepo.SaveAppartmentToDB(appartmentdata);

        }

        public AppartmentViewModel GetAppartmentById(int appartmentId)
        {
            throw new NotImplementedException();
        }
    }
}
