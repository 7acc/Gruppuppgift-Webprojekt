using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels2.VyModels;
using Webb4_DAL;
using Webb4_DAL.ModelsV2;
using Webb4_DAL.Repositories;

namespace Webb4_businesslayer.HelpMapper
{
    public class HousingTypeMapping
    {
        // HousingTypeModelIRepository<HousingType> _genericRepository = new HousingTypeModelIRepository<HousingType>(new Webb4Context());
        GenericRepository<HousingType> _genericRepository = new GenericRepository<HousingType>(new Webb4Context());

        public  IEnumerable<HousingTypeViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<HousingType>, IEnumerable<HousingTypeViewModel>>(getData);
            return randomItem;
        }

        public  async Task<HousingTypeViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<HousingType, HousingTypeViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(HousingTypeViewModel housing)
        {
            var addMap = Mapper.Map<HousingTypeViewModel, HousingType>(housing);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(HousingTypeViewModel housing)
        {
            var editMap = Mapper.Map<HousingTypeViewModel, HousingType>(housing);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
