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
        // OrderApartDataModelRepository<OrderApart> _genericRepository = new OrderApartDataModelRepository<OrderApart>(new Webb4Context());
        GenericRepository<OrderApart> _genericRepository = new GenericRepository<OrderApart>(new Webb4Context());

        public  IEnumerable<OrderApartViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<OrderApart>, IEnumerable<OrderApartViewModel>>(getData);
            return randomItem;
        }

        public  async Task<OrderApartViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<OrderApart, OrderApartViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(OrderApartViewModel adress)
        {
            var addMap = Mapper.Map<OrderApartViewModel, OrderApart>(adress);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(OrderApartViewModel adress)
        {
            var editMap = Mapper.Map<OrderApartViewModel, OrderApart>(adress);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
