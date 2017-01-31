using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels2.VyModels;
using Webb4_DAL;
using Webb4_DAL.ModelsV2;
using Webb4_DAL.Repositories;

namespace Webb4_businesslayer.HelpMapper
{
    public class AdressMapping
    {
        GenericRepository<Adress> _genericRepository = new GenericRepository<Adress>(new Webb4Context());

        public List<AdressViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll();
            var randomItem = Mapper.Map<List<Adress>, List<AdressViewModel>>(new List<Adress>(getData));
            return randomItem;
        }

        public async Task<AdressViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<Adress, AdressViewModel>(getRepo);
            return detailsId;
        }

        public async Task FromBltoUiInser(AdressViewModel Appart)
        {
            var addMap = Mapper.Map<AdressViewModel, Adress>(Appart);
            await _genericRepository.InsertAsync(addMap);

        }

        public async Task FromBltoUiEditAsync(AdressViewModel Appart)
        {
            var editMap = Mapper.Map<AdressViewModel, Adress>(Appart);
            await _genericRepository.EditAsync(editMap);

        }

        public async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
