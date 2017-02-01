using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ViewModels2.VyModels;
using Webb4_DAL.Repositories;
using Webb4_DAL.ModelsV2;
using Webb4_DAL;

namespace Webb4_businesslayer.HelpMapper
{
    public class AppartmentMapping
    {
        // AppartmentDataModelRepository<ApartmentData> _genericRepository = new AppartmentDataModelRepository<ApartmentData>(new Webb4Context());
        GenericRepository<Appartment> _genericRepository = new GenericRepository<Appartment>(new Webb4Context());

        public List<AppartmentViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll()
                .Include("Adress").Include("Housing").Include("District")
                .Select(p => new AppartmentViewModel()
                {
                    Id = p.Id,
                    Area = p.Area,
                    Rent = p.Rent,
                    NrOfRooms = p.NrOfRooms,
                    BuildinFloors = p.BuildinFloors,
                    Floor = p.Floor,
                    MainImgUrl = p.MainImgUrl,
                    BuildYear = p.BuildYear,
                    MoveInDate = p.MoveInDate,
                    LastAdmissionDate = p.LastAdmissionDate,
                    PublicationDate = p.PublicationDate,
                    Avalible = p.Avalible,
                    //Adress = new AdressViewModel() { Id = p.Adress.Id, Street = p.Adress.Street, City = p.Adress.City, PostalNr = p.Adress.PostalNr },
                    //Housing = new HousingTypeViewModel() { Id = p.Housing.Id, Type = p.Housing.Type },
                    //District = new DistrictViewModel() { Id = p.District.Id, Name = p.District.Name, Description = p.District.Description }

                })
                //.ProjectTo<AppartmentViewModel>()
                .ToList();

            //var randomItem = Mapper.Map<List<Appartment>, List<AppartmentViewModel>>(getData);
            return getData;
        }

        public List<AppartmentViewModel> FromBlToUiGetApartList()
        {
           
            var getData = _genericRepository.GetAll().Include("Adress")
                .Include("Housing").Include("District")
               .Select(p => new AppartmentViewModel()
               {
                   Id = p.Id,
                   Area = p.Area,
                   Rent = p.Rent,
                   NrOfRooms = p.NrOfRooms,
                   BuildinFloors = p.BuildinFloors,
                   Floor = p.Floor,
                   MainImgUrl = p.MainImgUrl,
                   BuildYear = p.BuildYear,
                   MoveInDate = p.MoveInDate,
                   LastAdmissionDate = p.LastAdmissionDate,
                   PublicationDate = p.PublicationDate,
                   Avalible = p.Avalible,
                   
               })
                .ToList();
            return getData;
        } 
        public  AppartmentViewModel FromBltoUiGetById(int id)
        {
            var getRepo = _genericRepository.GetAll().Include("Adress")
                .Include("Housing").Include("District").Include("Features").First(x=>x.Id == id);
            var detailsId = Mapper.Map<Appartment, AppartmentViewModel>(getRepo);
            return detailsId;
        }

        //public async Task<AppartmentViewModel> FromBltoUiGetById(int id)
        //{
        //    var getRepo = await _genericRepository.GetByIdAsync(id);
        //    var detailsId = Mapper.Map<Appartment, AppartmentViewModel>(getRepo);
        //    return detailsId;
        //}


        public  async Task FromBltoUiInser(AppartmentViewModel Appart)
        {
            var addMap = Mapper.Map<AppartmentViewModel, Appartment>(Appart);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(AppartmentViewModel Appart)
        {
            var editMap = Mapper.Map<AppartmentViewModel, Appartment>(Appart);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
