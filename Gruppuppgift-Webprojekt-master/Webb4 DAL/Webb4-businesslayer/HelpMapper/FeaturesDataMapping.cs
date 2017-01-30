using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels.VyModels;
using Webb4_DAL;
using Webb4_DAL.Models;
using Webb4_DAL.Repositories;

namespace Webb4_businesslayer.HelpMapper
{
    public class FeaturesDataMapping
    {
        // FeaturesDataModelRepository<FeaturesData> _genericRepository = new FeaturesDataModelRepository<FeaturesData>(new Webb4Context());
        GenericRepository<FeaturesData> _genericRepository = new GenericRepository<FeaturesData>(new Webb4Context());
        public  IEnumerable<FeaturesViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<FeaturesData>, IEnumerable<FeaturesViewModel>>(getData);
            return randomItem;
        }

        public  async Task<FeaturesViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<FeaturesData, FeaturesViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(FeaturesViewModel featur)
        {
            var addMap = Mapper.Map<FeaturesViewModel, FeaturesData>(featur);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(FeaturesViewModel featur)
        {
            var editMap = Mapper.Map<FeaturesViewModel, FeaturesData>(featur);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
