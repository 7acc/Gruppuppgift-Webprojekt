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
        // FormHousingDataModelIRepository<FormHousingData> _genericRepository = new FormHousingDataModelIRepository<FormHousingData>(new Webb4Context());
        GenericRepository<FormHousingData> _genericRepository = new GenericRepository<FormHousingData>(new Webb4Context());

        public  IEnumerable<FormHousingViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<FormHousingData>, IEnumerable<FormHousingViewModel>>(getData);
            return randomItem;
        }

        public  async Task<FormHousingViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<FormHousingData, FormHousingViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(FormHousingViewModel housing)
        {
            var addMap = Mapper.Map<FormHousingViewModel, FormHousingData>(housing);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(FormHousingViewModel housing)
        {
            var editMap = Mapper.Map<FormHousingViewModel, FormHousingData>(housing);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
