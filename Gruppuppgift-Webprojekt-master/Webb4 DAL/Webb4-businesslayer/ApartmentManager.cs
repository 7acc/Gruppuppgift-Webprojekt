using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.Repositories;
using Webb4_DAL.ModelsV2;
using System.Web;
using ViewModels2.VyModels;

namespace Webb4_businesslayer
{
    public class AppartmentManager
    {
        private ApartmentRepository apartmentRepo { get; set; }
        private PhotoManager PhotoManager { get; set; }
        public AppartmentManager()
        {
            apartmentRepo = new ApartmentRepository();
            PhotoManager = new PhotoManager();
        }

        public List<AppartmentViewModel> GetAppartmentList()
        {
            var list = apartmentRepo.GetAll();
            var viewList = list.Select(x => x.ApartmentToViewModel()).ToList();

            return viewList;

        }
        public void AddAppartmentWithPhotosToDB(AppartmentViewModel appartmentToAdd, HttpPostedFileBase MainIMG, IEnumerable<HttpPostedFileBase> photos, string root)
        {
            var appartmentdata = appartmentToAdd.ViewModelToAppartment();
            appartmentdata.PublicationDate = DateTime.Now;


            var listOfPhotos = new List<AppartmentPhoto>();
            foreach (var photo in photos)
            {
                var photoData = new AppartmentPhoto()
                {
                    Name = Guid.NewGuid(),
                    Appartment = appartmentdata
                };

                string url = PhotoManager.SavePhotoToCataloge(photo, root, photoData.Name);// not implemented!!!! LAZY AS BITCH

                photoData.URL = url;
                listOfPhotos.Add(photoData);
            }

            var MainUrl = PhotoManager.SavePhotoToCataloge(MainIMG, root, Guid.NewGuid());
            appartmentdata.Photos = listOfPhotos;
            appartmentdata.MainImgUrl = MainUrl;
            apartmentRepo.SaveAppartmentToDB(appartmentdata);
            //apartmentRepo.SaveApartmentPhotos(listOfPhotos);

        }

        public AppartmentViewModel GetAppartmentById(int appartmentId)
        {
            throw new NotImplementedException();
        }
    }
}
