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
    public class AdressMapping
    {
        static AdressDataModelRepository<AdressData> _adressRepository = new AdressDataModelRepository<AdressData>(new Webb4Context());

        public static IEnumerable<AdressViewModel> FromBltoUiGetAll()
        {
            var getData = _adressRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<AdressData>, IEnumerable<AdressViewModel>>(getData);
            return randomItem;
        }

        public static async Task<AdressViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _adressRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<AdressData, AdressViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(AdressViewModel adress)
        {
            var addMap = Mapper.Map<AdressViewModel, AdressData>(adress);
            await _adressRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(AdressViewModel adress)
        {
            var editMap = Mapper.Map<AdressViewModel, AdressData>(adress);
            await _adressRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _adressRepository.GetByIdAsync(id);
            await _adressRepository.DeleteAsync(getFromR);

        }
    }
}
