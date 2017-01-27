
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
                new SizeData{Id = 1, SizekName= "Ettor", Description= "Ett sovrum & köket",},
                new SizeData{Id = 2, SizekName= "Tvåor", Description= "2 sovrums & köket",},
                new SizeData{Id = 3, SizekName= "Treor", Description= "3 sovrums & köket",},
                new SizeData{Id = 4, SizekName= "Fyror", Description= "4 sovrums & köket",},
                new SizeData{Id = 5, SizekName= "Femmor", Description= "5 sovrums & köket",},
                new SizeData{Id = 6, SizekName= "Sexor", Description= "6 sovrums & köket",}
            };
            size.ForEach(s => context.SizeDataModels.Add(s));

            var formHousingData = new List<FormHousingData>
            {
                new FormHousingData{Id = 1,FormOfHousing ="Student",Description="Du har möjlighet att anmäla ditt intresse till denna lägenhet om du är student.",},
                new FormHousingData{Id = 2,FormOfHousing ="Seniorboende",Description="Du har möjlighet att anmäla ditt intresse till denna lägenhet från det år du fyller 55.",},
                new FormHousingData{Id = 3,FormOfHousing ="Nybyggt",Description="Det är nybyggt lägenhet.",}
             
            };
            formHousingData.ForEach(s => context.FormHousingDataModels.Add(s));

            var featuresData = new List<FeaturesData>
            {
                new FeaturesData{Id = 1, Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = 2, Elevator=false, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = 3, Elevator=false, Balcony= false, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = 4, Elevator=false, Balcony= false, Comhem=false, WashingMachine=true, },
                new FeaturesData{Id = 5, Elevator=false, Balcony= false, Comhem=false, WashingMachine=false, }
            };
            featuresData.ForEach(s => context.FeatuersDataModels.Add(s));

            var areaData = new List<AreaData>
            {
            new AreaData{Id = 1, AreaName = "Centrum ", ImageUrl = "ImageNameHar", Description = "Centrum ligger precis vid havet. Våra hus i Norra Hamnen ligger på första parkett ut mot sundet och strandpromenaden och hör till de absolut mest attraktiva i vårt lägenhetsbestånd. "
            },
            new AreaData{Id = 2, AreaName = "Dalhem", ImageUrl = "ImageNameHar", Description = "I den nordöstra delen av Helsingborg ligger Dalhem. Ett område med mycket grönska, bilfria gårdar, fina lekplatser och ett eget litet centrum. "
            },
            new AreaData{Id = 3, AreaName = "Elineberg", ImageUrl = "ImageNameHar", Description = "Vid Helsingborgs södra infart, ca 2,5 km från centrum ligger det familjära Elineberg.  "
            },
            new AreaData{Id = 4, AreaName = "Fredriksdal", ImageUrl = "ImageNameHar", Description = "Fredriksdal är ett stabilt och trivsamt område, ca två km öster om centrum. I områdets sydvästra del ligger Fredriksdalsparken med friluftsteater, museum och trädgårdar. "
            },
            new AreaData{Id = 5, AreaName = "Gustavslund", ImageUrl = "ImageNameHar", Description = "Gustavslund ligger i Helsingborgs östra utkant, ca 3 km från centrum med Skånes åkerlandskap som granne i öst. "
            },
            };
            areaData.ForEach(s => context.AreaDataModels.Add(s));

            var apartmentPhotoData = new List<ApartmentPhotoData>
            {
                new ApartmentPhotoData{Id= 1, Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true, PhotoSize=200},
                new ApartmentPhotoData{Id= 2, Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true, PhotoSize=200},
                new ApartmentPhotoData{Id= 3, Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true, PhotoSize=200},
                new ApartmentPhotoData{Id= 4, Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true, PhotoSize=200},
                new ApartmentPhotoData{Id= 5, Url="Url", Description="Description", UpdataDate= DateTime.Now, Status= true, PhotoSize=200}
            };
            apartmentPhotoData.ForEach(s => context.ApartmentPhotoDataModels.Add(s));
            var userId = new UserData();

            var orderApart = new List<OrderApart>
            {
                new OrderApart{Id= 1,Name="Katrina", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalius",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id= 2,Name="Anders", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=100,Price=300,OrderName="Anders",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id= 3,Name="Ali", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=60,Price=300,OrderName="Jack",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id= 4,Name="Dalius", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Schirsad",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id= 5,Name="Anders", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Katrin",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", }
            };
            orderApart.ForEach(s => context.OrderDataModels.Add(s));
            var apartid= new ApartmentData();
            var userData = new List<UserData>
            {
            new UserData{Id = 1, ApartmentId = apartid.Id, UserName="Ali"     ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", },
            new UserData{Id = 2, ApartmentId = apartid.Id, UserName="Anders",Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", },
            new UserData{Id = 3, ApartmentId = apartid.Id, UserName="Katrin",Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", },
            new UserData{Id = 4, ApartmentId = apartid.Id, UserName="Anders"      ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", },
            new UserData{Id = 5, ApartmentId = apartid.Id, UserName="Ali"  ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", },
            new UserData{Id = 6, ApartmentId = apartid.Id, UserName="Katrin"   ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", },
            new UserData{Id = 7, ApartmentId = apartid.Id, UserName="User"    ,Password="password", Email="Email@E.se", Address="HemLos",City="helsingobrg",Region="Skåne",PostalCode="26334",Country="Sweden",Phone="0011223344", }
            };
            userData.ForEach(s => context.UserDatagDataModels.Add(s));
            var apartmentData = new List<ApartmentData>
            {
                new ApartmentData{Id = 1, FormHld = 1, SizeID = 1, BuildYear = 1980, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 2, FormHld = 2, SizeID = 2, BuildYear = 1977, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 3, FormHld = 3, SizeID = 3, BuildYear = 2000, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 4, FormHld = 1, SizeID = 4, BuildYear = 2005, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 5, FormHld = 2, SizeID = 5, BuildYear = 1999, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 1, FormHld = 3, SizeID = 1, BuildYear = 1980, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 2, FormHld = 1, SizeID = 3, BuildYear = 1977, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 3, FormHld = 2, SizeID = 2, BuildYear = 2000, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 4, FormHld = 3, SizeID = 4, BuildYear = 2005, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)},
                new ApartmentData{Id = 5, FormHld = 3, SizeID = 1, BuildYear = 1999, ApartmentArea = 80, Floor = 4, Price = 8000, Address ="Långarödsvägen 99", City = "Helsingborg", Region = "Skåne", PostalCode ="23554", Country ="Sverige", Available =DateTime.Now.AddDays(5), DeadlineDate = DateTime.Now.AddDays(15)}
            };

        }                            
}
}