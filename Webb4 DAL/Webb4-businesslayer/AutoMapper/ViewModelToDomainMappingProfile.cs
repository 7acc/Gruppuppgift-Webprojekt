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
            //CreateMap<AdressViewModel, AdressData>()
            //    .ForMember(dto => dto.AdressApartmentM, opt => opt.MapFrom(src => src.AdressApartment));
            CreateMap<ApartmentViewModel, ApartmentData>()
                  .ForMember(dto => dto.ApartmentPhotoM, opt => opt.MapFrom(src => src.ApartmentPhoto))
                .ForMember(dto => dto.ApartmentAreaM, opt => opt.MapFrom(src => src.ApartmentAreaV))
                .ForMember(dto => dto.ApartmentUserM, opt => opt.MapFrom(src => src.ApartmentUser))
                .ForMember(dto => dto.ApartmentFeatureM, opt => opt.MapFrom(src => src.ApartmentFeature))
                .ForMember(dto => dto.ApartmentSizeM, opt => opt.MapFrom(src => src.ApartmentSize))
                .ForMember(dto => dto.ApartmentFormHousingM, opt => opt.MapFrom(src => src.ApartmentFormHousing));
            CreateMap<ApartmentPhotoViewModel, ApartmentPhotoData>()
                .ForMember(dto => dto.PhotoInApartM, opt => opt.MapFrom(src => src.PhotoInApart));
            CreateMap<AreaViewModel, AreaData>()
                .ForMember(dto => dto.AreaApartmentM, opt => opt.MapFrom(src => src.AreaApartment));
            CreateMap<FeaturesViewModel, FeaturesData>()
                .ForMember(dto => dto.FeatureApartmentM, opt => opt.MapFrom(src => src.FeatureApartment));
            CreateMap<FormHousingViewModel, FormHousingData>()
                 .ForMember(dto => dto.FormHousingApartmentM, opt => opt.MapFrom(src => src.FormHousingApartment));
            CreateMap<SizeViewModel, SizeData>()
                 .ForMember(dto => dto.SizeApartmentM, opt => opt.MapFrom(src => src.SizeApartment));
            CreateMap<UserDataViewModel, UserData>()
                .ForMember(dto => dto.UserApart, opt => opt.MapFrom(src => src.UserApart));
            CreateMap<OrderApartViewModel, OrderApart>()
               .ForMember(dto => dto.OrderAddress, opt => opt.MapFrom(src => src.OrderAddress))
               .ForMember(dto => dto.OrderCity, opt => opt.MapFrom(src => src.OrderCity))
               .ForMember(dto => dto.OrderCountry, opt => opt.MapFrom(src => src.OrderCountry))
               .ForMember(dto => dto.OrderName, opt => opt.MapFrom(src => src.OrderName))
               .ForMember(dto => dto.OrderPostalCode, opt => opt.MapFrom(src => src.OrderPostalCode))
               .ForMember(dto => dto.OrderRegion, opt => opt.MapFrom(src => src.OrderRegion));
        }
    }
}
