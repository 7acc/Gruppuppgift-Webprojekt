
using AutoMapper;
using ViewModels2.VyModels;
using Webb4_DAL.ModelsV2;

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
            CreateMap<Adress, AdressViewModel>();
            CreateMap<Appartment, AppartmentViewModel>()
                .ForMember(dto => dto.Adress, opt => opt.MapFrom(src => src.Adress))
                .ForMember(dto => dto.Housing, opt => opt.MapFrom(src => src.Housing))
                .ForMember(dto => dto.District, opt => opt.MapFrom(src => src.District))
                .ForMember(dto => dto.Features, opt => opt.MapFrom(src => src.Features))
                .ForMember(dto => dto.Photos, opt => opt.MapFrom(src => src.Photos))
                .ForMember(dto => dto.UsersFollowing, opt => opt.MapFrom(src => src.UsersFollowing));
            CreateMap<AppartmentPhoto, AppartmentPhotoViewModel>()
                .ForMember(dto => dto.Appartment, opt => opt.MapFrom(src => src.Appartment));
            CreateMap<Booking, BookingViewModel>()
                .ForMember(dto => dto.Appartment, opt => opt.MapFrom(src => src.Appartment));
            CreateMap<District, DistrictViewModel>();
            CreateMap<Features, FeaturesViewModel>()
                .ForMember(dto => dto.FeatureApartments, opt => opt.MapFrom(src => src.Appartments));
            CreateMap<HousingType, HousingTypeViewModel>();
            CreateMap<User, UserViewModel>()
                .ForMember(dto => dto.SavedAppartments, opt => opt.MapFrom(src => src.SavedAppartments));
        }
    }
}
