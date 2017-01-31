using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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

        public  List<AppartmentViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll();
            var randomItem = Mapper.Map<List<Appartment>, List<AppartmentViewModel>>(new List<Appartment>(getData));
            return randomItem;
        }

        public  async Task<AppartmentViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<Appartment, AppartmentViewModel>(getRepo);
            return detailsId;
        }

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
