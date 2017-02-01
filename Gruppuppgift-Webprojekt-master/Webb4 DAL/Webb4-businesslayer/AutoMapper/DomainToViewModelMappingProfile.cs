
using System.Linq;
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
                .ForMember(dto => dto.Adress, opt => opt.MapFrom(src => new AdressViewModel() { Id = src.Adress.Id, Street = src.Adress.Street, City = src.Adress.City, PostalNr = src.Adress.PostalNr }))
                .ForMember(dto => dto.Housing, opt => opt.MapFrom(src => new HousingTypeViewModel() { Id = src.Housing.Id, Type = src.Housing.Type }))
                .ForMember(dto => dto.District, opt => opt.MapFrom(src => new DistrictViewModel() { Id = src.District.Id, Name = src.District.Name, Description = src.District.Description }))
                .ForMember(dto => dto.Features, opt => opt.MapFrom(src => src.Features.Select(x=> new FeaturesViewModel() {Id = x.Id,name = x.name})))
                .ForMember(dto => dto.Photos, opt => opt.MapFrom(src => src.Photos.Select(x=> new AppartmentPhotoViewModel() {Id = x.Id, Name = x.Name,URL = x.URL, Description = x.Description, Approved = x.Approved})))
                .ForMember(dto => dto.UsersFollowing, opt => opt.MapFrom(src => src.UsersFollowing.Select(x => new UserViewModel() {Id = x.Id, Username = x.Username, Fname = x.Fname, Lname = x.Lname, Email = x.Email, Password = x.Password})));
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
