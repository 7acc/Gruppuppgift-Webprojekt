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
    public class FeaturesMapping
    {
        // FeaturesModelRepository<Features> _genericRepository = new FeaturesModelRepository<Features>(new Webb4Context());
        GenericRepository<Features> _genericRepository = new GenericRepository<Features>(new Webb4Context());
        public  IEnumerable<FeaturesViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<Features>, IEnumerable<FeaturesViewModel>>(getData);
            return randomItem;
        }

        public  async Task<FeaturesViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<Features, FeaturesViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(FeaturesViewModel featur)
        {
            var addMap = Mapper.Map<FeaturesViewModel, Features>(featur);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(FeaturesViewModel featur)
        {
            var editMap = Mapper.Map<FeaturesViewModel, Features>(featur);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
