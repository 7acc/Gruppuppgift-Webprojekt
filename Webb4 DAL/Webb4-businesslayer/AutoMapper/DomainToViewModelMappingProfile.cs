using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels.VyModels;
using Webb4_DAL.Models;

namespace Webb4_businesslayer.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            CreateMap<AdressDataModel, AdressDataViewModel>();
            CreateMap<AppartmentDataModel, AppartmentDataViewModel>();
            CreateMap<AppartmentPhotoDataModel, AppartmentPhotoDataViewModel>();
            CreateMap<FeaturesDataModel, FeaturesDataViewModel>();
            CreateMap<UserDataModel, UserDataViewModel>();
        }
    }
}
