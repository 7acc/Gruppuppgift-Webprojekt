using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Webb4_DAL.Repositories;
using Webb4_DAL.Models;
using Webb4_DAL;
using Webb4___MVC;
using Webb4___MVC.Models;

namespace Webb4_businesslayer
{
    public class ApartmentMapping
    {
        AppartmentDataModelRepository<AppartmentDataModel> appartmentRepository = new AppartmentDataModelRepository<AppartmentDataModel>(new Webb4_Context());

        public List<ApartmentViewModel> GetAllApartments()
        {
            var appartments = appartmentRepository.GetAll();
            var listOfApartments = appartments.Select(x => DataModelToViewModel(x)).ToList();

            return listOfApartments;

        }



        public ApartmentViewModel DataModelToViewModel(AppartmentDataModel dataModel)
        {
            ApartmentViewModel viewModel = new ApartmentViewModel();
            
            // logig goes here

            return viewModel;
        }
    }
}
