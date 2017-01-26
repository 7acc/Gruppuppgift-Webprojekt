
using System;
using System.Collections.Generic;
using Webb4_DAL;
using Webb4_DAL.Models;

namespace Webb4_businesslayer
{

    public class Webb4MvcInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Webb4Context>
    {
        protected override void Seed(Webb4Context context)
        {
           
            var size = new List<SizeData>
            {
                new SizeData{Id = Guid.NewGuid(), SizekName= "Ettor", Description= "Ett sovrum & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Ettor", Description= "Ett sovrum & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Ettor", Description= "Ett sovrum & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Ettor", Description= "Ett sovrum & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Ettor", Description= "Ett sovrum & köket",}
            };
            size.ForEach(s => context.SizeDataModels.Add(s));

            var formHousingData = new List<FormHousingData>
            {
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="FormOfHousing",Description="Description",},
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="FormOfHousing",Description="Description",},
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="FormOfHousing",Description="Description",},
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="FormOfHousing",Description="Description",},
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="FormOfHousing",Description="Description",}
            };
            formHousingData.ForEach(s => context.FormHousingDataModels.Add(s));

            var featuresData = new List<FeaturesData>
            {
                new FeaturesData{Id = Guid.NewGuid(), Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, }
            };
            featuresData.ForEach(s => context.FeatuersDataModels.Add(s));

            var areaData = new List<AreaData>
            {
            new AreaData{Id = Guid.NewGuid(), AreaName = "SoderAD", ImageUrl = "ImageNameHar", Description = "Hello Helsingborg"
            }
            };
            areaData.ForEach(s => context.AreaDataModels.Add(s));

            var apartmentPhotoData = new List<ApartmentPhotoData>
            {
                new ApartmentPhotoData{Id=Guid.NewGuid(), Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true,PhotoSize=200},
                new ApartmentPhotoData{Id=Guid.NewGuid(), Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true,PhotoSize=200},
                new ApartmentPhotoData{Id=Guid.NewGuid(), Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true,PhotoSize=200},
                new ApartmentPhotoData{Id=Guid.NewGuid(), Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true,PhotoSize=200},
                new ApartmentPhotoData{Id=Guid.NewGuid(), Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true,PhotoSize=200}
            };
            apartmentPhotoData.ForEach(s => context.ApartmentPhotoDataModels.Add(s));
            var userId = new UserData();

            var orderApart = new List<OrderApart>
            {
                new OrderApart{Id=Guid.NewGuid(),Name="Katrina", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Katrina", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Katrina", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Katrina", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Katrina", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", }
            };
            orderApart.ForEach(s => context.OrderDataModels.Add(s));
            var apartid= new ApartmentData();
            var userData = new List<UserData>
            {
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Chemistry"     ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", },
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Microeconomics",Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", },
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Macroeconomics",Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", },
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Calculus"      ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", },
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Trigonometry"  ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", },
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Composition"   ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", },
            new UserData{Id = Guid.NewGuid(),ApartmentId = apartid.Id, UserName="Literature"    ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="1",Country="Sweden",Phone="0011223344", }
            };
            userData.ForEach(s => context.UserDatagDataModels.Add(s));

           
        }
    }
}
