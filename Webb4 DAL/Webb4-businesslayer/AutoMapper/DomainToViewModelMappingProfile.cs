
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
            //CreateMap<AdressData, AdressViewModel>()
            //     .ForMember(dto => dto.AdressApartment, opt => opt.MapFrom(src => src.AdressApartmentM));
            CreateMap<ApartmentData, ApartmentViewModel>()
                .ForMember(dto => dto.ApartmentPhoto, opt => opt.MapFrom(src => src.ApartmentPhotoM))
                .ForMember(dto => dto.ApartmentAreaV, opt => opt.MapFrom(src => src.ApartmentAreaM))
                .ForMember(dto => dto.ApartmentUser, opt => opt.MapFrom(src => src.ApartmentUserM))
                .ForMember(dto => dto.ApartmentFeature, opt => opt.MapFrom(src => src.ApartmentFeatureM))
                .ForMember(dto => dto.ApartmentSize, opt => opt.MapFrom(src => src.ApartmentSizeM))
                .ForMember(dto => dto.ApartmentFormHousing, opt => opt.MapFrom(src => src.ApartmentFormHousingM));
            CreateMap<ApartmentPhotoData, ApartmentPhotoViewModel>()
                .ForMember(dto => dto.PhotoInApart, opt => opt.MapFrom(src => src.PhotoInApartM));
            CreateMap<AreaData, AreaViewModel>()
                .ForMember(dto => dto.AreaApartment, opt => opt.MapFrom(src => src.AreaApartmentM));
            CreateMap<FeaturesData, FeaturesViewModel>()
                 .ForMember(dto => dto.FeatureApartment, opt => opt.MapFrom(src => src.FeatureApartmentM));
            CreateMap<FormHousingData, FormHousingViewModel>()
                 .ForMember(dto => dto.FormHousingApartment, opt => opt.MapFrom(src => src.FormHousingApartmentM));
            CreateMap<SizeData, SizeViewModel>()
                 .ForMember(dto => dto.SizeApartment, opt => opt.MapFrom(src => src.SizeApartmentM));
            CreateMap<UserData, UserDataViewModel>()
                .ForMember(dto => dto.UserApart, opt => opt.MapFrom(src => src.UserApart));
            CreateMap<OrderApart, OrderApartViewModel>()
               .ForMember(dto => dto.OrderAddress, opt => opt.MapFrom(src => src.OrderAddress))
               .ForMember(dto => dto.OrderCity, opt => opt.MapFrom(src => src.OrderCity))
               .ForMember(dto => dto.OrderCountry, opt => opt.MapFrom(src => src.OrderCountry))
               .ForMember(dto => dto.OrderName, opt => opt.MapFrom(src => src.OrderName))
               .ForMember(dto => dto.OrderPostalCode, opt => opt.MapFrom(src => src.OrderPostalCode))
               .ForMember(dto => dto.OrderRegion, opt => opt.MapFrom(src => src.OrderRegion));
        }
    }
}
