
using AutoMapper;
using ViewModels2.VyModels;
using Webb4_DAL.ModelsV2;

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
            CreateMap<AdressViewModel, Adress>();
            CreateMap<AppartmentViewModel, Appartment>()
                .ForMember(dto => dto.Adress, opt => opt.MapFrom(src => src.Adress))
                .ForMember(dto => dto.Housing, opt => opt.MapFrom(src => src.Housing))
                .ForMember(dto => dto.District, opt => opt.MapFrom(src => src.District))
                .ForMember(dto => dto.Features, opt => opt.MapFrom(src => src.Features))
                .ForMember(dto => dto.Photos, opt => opt.MapFrom(src => src.Photos))
                .ForMember(dto => dto.UsersFollowing, opt => opt.MapFrom(src => src.UsersFollowing));
            CreateMap<AppartmentPhotoViewModel, AppartmentPhoto>()
                .ForMember(dto => dto.Appartment, opt => opt.MapFrom(src => src.Appartment));
            CreateMap<BookingViewModel, Booking>()
                .ForMember(dto => dto.Appartment, opt => opt.MapFrom(src => src.Appartment));
            CreateMap<DistrictViewModel, District>();
            CreateMap<FeaturesViewModel, Features>()
                .ForMember(dto => dto.Appartments, opt => opt.MapFrom(src => src.FeatureApartments));
            CreateMap<HousingTypeViewModel, HousingType>();
            CreateMap<UserViewModel, User>()
                .ForMember(dto => dto.SavedAppartments, opt => opt.MapFrom(src => src.SavedAppartments));
        }
    }
}
