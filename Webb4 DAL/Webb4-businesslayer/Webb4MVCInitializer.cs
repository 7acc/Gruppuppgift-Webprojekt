
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
                new SizeData{Id = Guid.NewGuid(), SizekName= "Tvåor", Description= "2 sovrums & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Treor", Description= "3 sovrums & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Fyror", Description= "4 sovrums & köket",},
                new SizeData{Id = Guid.NewGuid(), SizekName= "Femmor", Description= "5 sovrums & köket",},
                 new SizeData{Id = Guid.NewGuid(), SizekName= "Sexor", Description= "6 sovrums & köket",}
            };
            size.ForEach(s => context.SizeDataModels.Add(s));

            var formHousingData = new List<FormHousingData>
            {
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="Student",Description="Du har möjlighet att anmäla ditt intresse till denna lägenhet om du är student.",},
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="Seniorboende",Description="Du har möjlighet att anmäla ditt intresse till denna lägenhet från det år du fyller 55.",},
                new FormHousingData{Id = Guid.NewGuid(),FormOfHousing ="Nybyggt",Description="Det är nybyggt lägenhet.",}
             
            };
            formHousingData.ForEach(s => context.FormHousingDataModels.Add(s));

            var featuresData = new List<FeaturesData>
            {
                new FeaturesData{Id = Guid.NewGuid(), Elevator=true, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=false, Balcony= true, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=false, Balcony= false, Comhem=true, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=false, Balcony= false, Comhem=false, WashingMachine=true, },
                new FeaturesData{Id = Guid.NewGuid(), Elevator=false, Balcony= false, Comhem=false, WashingMachine=false, }
            };
            featuresData.ForEach(s => context.FeatuersDataModels.Add(s));

            var areaData = new List<AreaData>
            {
            new AreaData{Id = Guid.NewGuid(), AreaName = "Centrum ", ImageUrl = "ImageNameHar", Description = "Centrum ligger precis vid havet. Våra hus i Norra Hamnen ligger på första parkett ut mot sundet och strandpromenaden och hör till de absolut mest attraktiva i vårt lägenhetsbestånd. "
            },
             new AreaData{Id = Guid.NewGuid(), AreaName = "Dalhem", ImageUrl = "ImageNameHar", Description = "I den nordöstra delen av Helsingborg ligger Dalhem. Ett område med mycket grönska, bilfria gårdar, fina lekplatser och ett eget litet centrum. "
            },
              new AreaData{Id = Guid.NewGuid(), AreaName = "Elineberg", ImageUrl = "ImageNameHar", Description = "Vid Helsingborgs södra infart, ca 2,5 km från centrum ligger det familjära Elineberg.  "
            },
              new AreaData{Id = Guid.NewGuid(), AreaName = "Fredriksdal", ImageUrl = "ImageNameHar", Description = "Fredriksdal är ett stabilt och trivsamt område, ca två km öster om centrum. I områdets sydvästra del ligger Fredriksdalsparken med friluftsteater, museum och trädgårdar. "
            },
               new AreaData{Id = Guid.NewGuid(), AreaName = "Gustavslund", ImageUrl = "ImageNameHar", Description = "Gustavslund ligger i Helsingborgs östra utkant, ca 3 km från centrum med Skånes åkerlandskap som granne i öst. "
            },
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
                new OrderApart{Id=Guid.NewGuid(),Name="Anders", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=100,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Ali", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=60,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Dalius", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", },
                new OrderApart{Id=Guid.NewGuid(),Name="Anders", UserId =userId.Id , InterestDate=DateTime.Now,RequiredDate=DateTime.Now,OccupancyDate=DateTime.Now,ApartmentArea=200,Price=300,OrderName="Dalyus",OrderAddress="Helsingborg",OrderCity="OrderCity",OrderRegion="OrderRegion",OrderPostalCode="OrderPostalCode",OrderCountry="OrderCountry", }
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
