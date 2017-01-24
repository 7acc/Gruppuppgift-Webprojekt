using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels.VyModels;
using Webb4_DAL;
using Webb4_DAL.Models;
using Webb4_DAL.Repositories;

namespace Webb4_businesslayer.HelpMapper
{
    public class SizeDataMapping
    {
        static SizeDataIRepository<SizeData> _sizeDataRepository = new SizeDataIRepository<SizeData>(new Webb4Context());

        public static IEnumerable<SizeViewModel> FromBltoUiGetAll()
        {
            var getData = _sizeDataRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<SizeData>, IEnumerable<SizeViewModel>>(getData);
            return randomItem;
        }

        public static async Task<SizeViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _sizeDataRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<SizeData, SizeViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(SizeViewModel adress)
        {
            var addMap = Mapper.Map<SizeViewModel, SizeData>(adress);
            await _sizeDataRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(SizeViewModel adress)
        {
            var editMap = Mapper.Map<SizeViewModel, SizeData>(adress);
            await _sizeDataRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _sizeDataRepository.GetByIdAsync(id);
            await _sizeDataRepository.DeleteAsync(getFromR);

        }
    }
}
