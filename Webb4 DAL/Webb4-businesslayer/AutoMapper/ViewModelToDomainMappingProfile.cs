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
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            CreateMap<AdressDataViewModel, AdressDataModel>();
            CreateMap<AppartmentDataViewModel, AppartmentDataModel>();
            CreateMap<AppartmentPhotoDataViewModel, AppartmentPhotoDataModel>();
            CreateMap<FeaturesDataViewModel, FeaturesDataModel>();
            CreateMap<UserDataViewModel, UserDataModel>();
        }
    }
}
