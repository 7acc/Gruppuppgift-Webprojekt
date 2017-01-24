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
    public class FormHousingDataMapping
    {
        static FormHousingDataModelIRepository<FormHousingData> _FormHousingRepository = new FormHousingDataModelIRepository<FormHousingData>(new Webb4Context());

        public static IEnumerable<FormHousingViewModel> FromBltoUiGetAll()
        {
            var getData = _FormHousingRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<FormHousingData>, IEnumerable<FormHousingViewModel>>(getData);
            return randomItem;
        }

        public static async Task<FormHousingViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _FormHousingRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<FormHousingData, FormHousingViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(FormHousingViewModel housing)
        {
            var addMap = Mapper.Map<FormHousingViewModel, FormHousingData>(housing);
            await _FormHousingRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(FormHousingViewModel housing)
        {
            var editMap = Mapper.Map<FormHousingViewModel, FormHousingData>(housing);
            await _FormHousingRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _FormHousingRepository.GetByIdAsync(id);
            await _FormHousingRepository.DeleteAsync(getFromR);

        }
    }
}
