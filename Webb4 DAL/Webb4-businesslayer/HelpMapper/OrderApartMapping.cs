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
    public class OrderApartMapping
    {
        static OrderApartDataModelRepository<OrderApart> _adressRepository = new OrderApartDataModelRepository<OrderApart>(new Webb4Context());

        public static IEnumerable<OrderApartViewModel> FromBltoUiGetAll()
        {
            var getData = _adressRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<OrderApart>, IEnumerable<OrderApartViewModel>>(getData);
            return randomItem;
        }

        public static async Task<OrderApartViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _adressRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<OrderApart, OrderApartViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(OrderApartViewModel adress)
        {
            var addMap = Mapper.Map<OrderApartViewModel, OrderApart>(adress);
            await _adressRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(OrderApartViewModel adress)
        {
            var editMap = Mapper.Map<OrderApartViewModel, OrderApart>(adress);
            await _adressRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _adressRepository.GetByIdAsync(id);
            await _adressRepository.DeleteAsync(getFromR);

        }
    }
}
