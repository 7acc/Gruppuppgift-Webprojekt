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
        static FeaturesDataModelRepository<FeaturesData> _FeaturRepository = new FeaturesDataModelRepository<FeaturesData>(new Webb4Context());

        public static IEnumerable<FeaturesViewModel> FromBltoUiGetAll()
        {
            var getData = _FeaturRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<FeaturesData>, IEnumerable<FeaturesViewModel>>(getData);
            return randomItem;
        }

        public static async Task<FeaturesViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _FeaturRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<FeaturesData, FeaturesViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(FeaturesViewModel featur)
        {
            var addMap = Mapper.Map<FeaturesViewModel, FeaturesData>(featur);
            await _FeaturRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(FeaturesViewModel featur)
        {
            var editMap = Mapper.Map<FeaturesViewModel, FeaturesData>(featur);
            await _FeaturRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _FeaturRepository.GetByIdAsync(id);
            await _FeaturRepository.DeleteAsync(getFromR);

        }
    }
}
