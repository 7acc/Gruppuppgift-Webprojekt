using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.ModelsV2;
using ViewModels2.VyModels;


namespace Webb4_businesslayer
{
    static class Test_Helper
    {
        public static UserViewModel UserToViewModel(this User UserToTransform)
        {
            var UserViewModel = new UserViewModel();

            UserViewModel.Id = UserToTransform.Id;
            UserViewModel.Email = UserToTransform.Email;
            UserViewModel.Username = $"{UserToTransform.Fname} {UserToTransform.Lname}";

            return UserViewModel;
        }

        public static User ViewModelToUser(this UserViewModel ViewModelToTransform)
        {
            var User = new User();

            User.Id = ViewModelToTransform.Id;
            User.Email = ViewModelToTransform.Email;
            User.Password = ViewModelToTransform.Password;

            return User;
        }

        //  Adress
        //---------------------------------------------------------------------------------

        public static AdressViewModel AdressToViewModel(this Adress AdressToTransform)
        {
            var AdressViewModel = new AdressViewModel();

            AdressViewModel.Id = AdressToTransform.Id;
            AdressViewModel.Street = AdressToTransform.Street;
            AdressViewModel.PostalNr = AdressToTransform.PostalNr;
            AdressViewModel.City = AdressToTransform.City;

            return AdressViewModel;
        }

        public static Adress ViewModelToUser(this AdressViewModel ViewModelToTransform)
        {
            var Adress = new Adress();

            Adress.Id = ViewModelToTransform.Id;
            Adress.Street = ViewModelToTransform.Street;
            Adress.PostalNr = ViewModelToTransform.PostalNr;
            Adress.City = ViewModelToTransform.City;

            return Adress;
        }

        //  Apartments
        //---------------------------------------------------------------------------------
        public static AppartmentViewModel ApartmentToViewModel(this Appartment ApartmentToTransform)
        {
            var ApartmentViewModel = new AppartmentViewModel();

            ApartmentViewModel.Id = ApartmentToTransform.Id;
            ApartmentViewModel.Area = ApartmentToTransform.Area;
            ApartmentViewModel.Rent = ApartmentToTransform.Rent;
            ApartmentViewModel.NrOfRooms = ApartmentToTransform.NrOfRooms;
            ApartmentViewModel.BuildinFloors = ApartmentToTransform.BuildinFloors;
            ApartmentViewModel.Floor = ApartmentToTransform.Floor;
            ApartmentViewModel.BuildYear = ApartmentToTransform.BuildYear;
            ApartmentViewModel.MoveInDate = ApartmentToTransform.MoveInDate;
            ApartmentViewModel.LastAdmissionDate = ApartmentToTransform.LastAdmissionDate;
            ApartmentViewModel.PublicationDate = ApartmentToTransform.PublicationDate;
            ApartmentViewModel.Avalible = ApartmentToTransform.Avalible;

            ApartmentViewModel.Adress = ApartmentToTransform.Adress;
            ApartmentViewModel.Housing = ApartmentToTransform.Housing;
            ApartmentViewModel.District = ApartmentToTransform.District;

            ApartmentViewModel.Features = ApartmentToTransform.Features;
            ApartmentViewModel.Photos = ApartmentToTransform.Photos;
            ApartmentViewModel.UsersFollowing = ApartmentToTransform.UsersFollowing;

            return ApartmentViewModel;
        }

        public static Appartment ViewModelToAppartment(this AppartmentViewModel ViewModelToTransform)
        {
            var Apartment = new Appartment();

            Apartment.Id = ViewModelToTransform.Id;
            Apartment.Area = ViewModelToTransform.Area;
            Apartment.Rent = ViewModelToTransform.Rent;
            Apartment.NrOfRooms = ViewModelToTransform.NrOfRooms;
            Apartment.BuildinFloors = ViewModelToTransform.BuildinFloors;
            Apartment.Floor = ViewModelToTransform.Floor;
            Apartment.BuildYear = ViewModelToTransform.BuildYear;
            Apartment.MoveInDate = ViewModelToTransform.MoveInDate;
            Apartment.LastAdmissionDate = ViewModelToTransform.LastAdmissionDate;
            Apartment.PublicationDate = ViewModelToTransform.PublicationDate;
            Apartment.Avalible = ViewModelToTransform.Avalible;

            Apartment.Adress = ViewModelToTransform.Adress;
            Apartment.Housing = ViewModelToTransform.Housing;
            Apartment.District = ViewModelToTransform.District;

            Apartment.Features = ViewModelToTransform.Features;
            Apartment.Photos = ViewModelToTransform.Photos;
            Apartment.UsersFollowing = ViewModelToTransform.UsersFollowing;

            return Apartment;
        }

        //  AppartmentPhoto
        //---------------------------------------------------------------------------------

        public static AppartmentPhotoViewModel AppartmentPhotoToViewModel(this AppartmentPhoto AppartmentPhotoToTransform)
        {
            var AppartmentPhotoViewModel = new AppartmentPhotoViewModel();

            AppartmentPhotoViewModel.Id = AppartmentPhotoToTransform.Id;
            AppartmentPhotoViewModel.Name = AppartmentPhotoToTransform.Name;
            AppartmentPhotoViewModel.URL = AppartmentPhotoToTransform.URL;
            AppartmentPhotoViewModel.Description = AppartmentPhotoToTransform.Description;
            AppartmentPhotoViewModel.AppartmentId = AppartmentPhotoToTransform.AppartmentId;
            AppartmentPhotoViewModel.Appartment = AppartmentPhotoToTransform.Appartment;

            return AppartmentPhotoViewModel;
        }

        public static AppartmentPhoto ViewModelToUser(this AppartmentPhotoViewModel ViewModelToTransform)
        {
            var AppartmentPhoto = new AppartmentPhoto();

            AppartmentPhoto.Id = ViewModelToTransform.Id;
            AppartmentPhoto.Name = ViewModelToTransform.Name;
            AppartmentPhoto.URL = ViewModelToTransform.URL;
            AppartmentPhoto.Description = ViewModelToTransform.Description;
            AppartmentPhoto.AppartmentId = ViewModelToTransform.AppartmentId;
            AppartmentPhoto.Appartment = ViewModelToTransform.Appartment;

            return AppartmentPhoto;
        }

        //  Booking
        //---------------------------------------------------------------------------------

        public static BookingViewModel BookingToViewModel(this Booking BookingToTransform)
        {
            var BookingViewModel = new BookingViewModel();

            BookingViewModel.Id = BookingToTransform.Id;
            BookingViewModel.booker = BookingToTransform.booker;
            BookingViewModel.Appartment = BookingToTransform.Appartment; 

            return BookingViewModel;
        }

        public static Booking ViewModelToUser(this BookingViewModel ViewModelToTransform)
        {
            var Booking = new Booking();

            Booking.Id = ViewModelToTransform.Id;
            Booking.booker = ViewModelToTransform.booker;
            Booking.Appartment = ViewModelToTransform.Appartment; 

            return Booking;
        }

        //  District
        //---------------------------------------------------------------------------------

        public static DistrictViewModel DistrictToViewModel(this District DistrictToTransform)
        {
            var DistrictViewModel = new DistrictViewModel();

            DistrictViewModel.Id = DistrictToTransform.Id;
            DistrictViewModel.Name = DistrictToTransform.Name;
            DistrictViewModel.Description = DistrictToTransform.Description;

            return DistrictViewModel;
        }

        public static District ViewModelToUser(this DistrictViewModel ViewModelToTransform)
        {
            var District = new District();

            District.Id = ViewModelToTransform.Id;
            District.Name = ViewModelToTransform.Name;
            District.Description = ViewModelToTransform.Description;

            return District;
        }

        //  Feautures | Måste ta bort den gamla modell för att den ej kan skilja mellan dessa två eftersom de har samma namn.
        //---------------------------------------------------------------------------------

        //public static FeaturesViewModel FeaturesToViewModel(this Features FeaturesToTransform)
        //{
        //    var FeaturesViewModel = new FeaturesViewModel();

        //    FeaturesViewModel.Id = FeaturesToTransform.Id;
        //    FeaturesViewModel.name = FeaturesToTransform.name;
        //    FeaturesViewModel.FeatureApartments = FeaturesToTransform.FeatureApartments;

        //    return FeaturesViewModel;
        //}

        //public static Features ViewModelToUser(this FeaturesViewModel ViewModelToTransform)
        //{
        //    var Features = new Features();

        //    Features.Id = ViewModelToTransform.Id;
        //    Features.name = ViewModelToTransform.name;
        //    Features.FeatureApartments = ViewModelToTransform.FeatureApartments;

        //    return Features;
        //}

        //  Booking
        //---------------------------------------------------------------------------------

        public static HousingTypeViewModel HousingTypeToViewModel(this HousingType HousingTypeToTransform)
        {
            var HousingTypeViewModel = new HousingTypeViewModel();

            HousingTypeViewModel.Id = HousingTypeToTransform.Id;
            HousingTypeViewModel.Type = HousingTypeToTransform.Type;

            return HousingTypeViewModel;
        }

        public static HousingType ViewModelToUser(this HousingTypeViewModel ViewModelToTransform)
        {
            var HousingType = new HousingType();

            HousingType.Id = ViewModelToTransform.Id;
            HousingType.Type = ViewModelToTransform.Type;

            return HousingType;
        }

        //  Nya User | I ViewModels2
        //---------------------------------------------------------------------------------

        //public static UserViewModel UserToViewModel(this User UserToTransform)
        //{
        //    var UserViewModel = new UserViewModel();

        //    UserViewModel.Id = UserToTransform.Id;
        //    UserViewModel.Username = UserToTransform.Username;
        //    UserViewModel.Fname = UserToTransform.Fname;
        //    UserViewModel.Lname = UserToTransform.Lname;
        //    UserViewModel.Email = UserToTransform.Email;
        //    UserViewModel.Password = UserToTransform.Password;
        //    UserViewModel.Adress = UserToTransform.Adress;
        //    UserViewModel.SavedAppartments = UserToTransform.SavedAppartments;

        //    return UserViewModel;
        //}

        //public static User ViewModelToUser(this UserViewModel ViewModelToTransform)
        //{
        //    var User = new User();

        //    User.Id = ViewModelToTransform.Id;
        //    User.Username = ViewModelToTransform.Username;
        //    User.Fname = ViewModelToTransform.Fname;
        //    User.Lname = ViewModelToTransform.Lname;
        //    User.Email = ViewModelToTransform.Email;
        //    User.Password = ViewModelToTransform.Password;
        //    User.Adress = ViewModelToTransform.Adress;
        //    User.SavedAppartments = ViewModelToTransform.SavedAppartments;

        //    return User;
        //}

    }

}
