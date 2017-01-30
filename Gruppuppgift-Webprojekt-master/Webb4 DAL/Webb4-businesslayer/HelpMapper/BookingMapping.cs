using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels2.VyModels;
using Webb4_DAL;
using Webb4_DAL.ModelsV2;
using Webb4_DAL.Repositories;

namespace Webb4_businesslayer.HelpMapper
{
    public class BookingMapping
    {
        // BookingModelIRepository<Booking> _genericRepository = new BookingModelIRepository<Booking>(new Webb4Context());
        GenericRepository<Booking> _genericRepository = new GenericRepository<Booking>(new Webb4Context());
        public  List<BookingViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<Booking>, List<BookingViewModel>>(getData);
            return randomItem;
        }

        public  async Task<BookingViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<Booking, BookingViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(BookingViewModel area)
        {
            var addMap = Mapper.Map<BookingViewModel, Booking>(area);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(BookingViewModel area)
        {
            var editMap = Mapper.Map<BookingViewModel, Booking>(area);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
