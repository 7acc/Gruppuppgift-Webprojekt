using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.ModelsV2;
using Webb4_DAL.ViewModels2;
using ViewModels.VyModels;


namespace Webb4_businesslayer
{
    static class Test_Helper
    {
        public static UserDataViewModel UserToViewModel(this User UserToTransform)
        {
            var UserViewModel = new UserDataViewModel();

            UserViewModel.Id = UserToTransform.Id;
            UserViewModel.Email = UserToTransform.Email;
            UserViewModel.UserName = $"{UserToTransform.Fname} {UserToTransform.Lname}";

            return UserViewModel;
        }

        public static User ViewModelToUser(this UserDataViewModel ViewModelToTransform)
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

    }

}
