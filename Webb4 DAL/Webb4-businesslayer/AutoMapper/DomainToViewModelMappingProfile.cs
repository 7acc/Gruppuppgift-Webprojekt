
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
            CreateMap<AdressData, AdressViewModel>()
                 .ForMember(dto => dto.AdressApartment, opt => opt.MapFrom(src => src.AdressApartmentM))
                 .ForMember(dto => dto.AdressUser, opt => opt.MapFrom(src => src.AdressUserM));
            CreateMap<ApartmentData, ApartmentViewModel>()
                .ForMember(dto => dto.ApartmentPhoto, opt => opt.MapFrom(src => src.ApartmentPhotoM))
                .ForMember(dto => dto.ApartmentAdress, opt => opt.MapFrom(src => src.ApartmentAdressM))
                .ForMember(dto => dto.ApartmentArea, opt => opt.MapFrom(src => src.ApartmentAreaM))
                .ForMember(dto => dto.ApartmentFeature, opt => opt.MapFrom(src => src.ApartmentFeatureM))
                .ForMember(dto => dto.ApartmentSize, opt => opt.MapFrom(src => src.ApartmentSizeM))
                .ForMember(dto => dto.ApartmentFormHousing, opt => opt.MapFrom(src => src.ApartmentFormHousingM));
            CreateMap<ApartmentPhotoData, ApartmentPhotoViewModel>()
                .ForMember(dto => dto.ApartmentPhoto, opt => opt.MapFrom(src => src.PhotoInApartM));
            CreateMap<AreaData, AreaViewModel>()
                .ForMember(dto => dto.AreaApartment, opt => opt.MapFrom(src => src.AreaApartmentM));
            CreateMap<FeaturesData, FeaturesViewModel>()
                 .ForMember(dto => dto.FeatureApartment, opt => opt.MapFrom(src => src.FeatureApartmentM));
            CreateMap<FormHousingData, FormHousingViewModel>()
                 .ForMember(dto => dto.FormHousingApartment, opt => opt.MapFrom(src => src.FormHousingApartmentM));
            CreateMap<SizeData, SizeViewModel>()
                 .ForMember(dto => dto.SizeApartment, opt => opt.MapFrom(src => src.SizeApartmentM));
            CreateMap<UserData, UserDataViewModel>()
                .ForMember(dto => dto.UserAdress, opt => opt.MapFrom(src => src.UserAdressM));
        }
    }
}
