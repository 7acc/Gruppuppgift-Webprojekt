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
    public class DistrictMapping
    {
        // DistrictDataModelRepository<District> _genericRepository = new DistrictDataModelRepository<District>(new Webb4Context());
        GenericRepository<District> _genericRepository = new GenericRepository<District>(new Webb4Context());

        public  IEnumerable<DistrictViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<District>, IEnumerable<DistrictViewModel>>(getData);
            return randomItem;
        }

        public  async Task<DistrictViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<District, DistrictViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(DistrictViewModel adress)
        {
            var addMap = Mapper.Map<DistrictViewModel, District>(adress);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(DistrictViewModel adress)
        {
            var editMap = Mapper.Map<DistrictViewModel, District>(adress);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
