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
        // SizeDataIRepository<SizeData> _genericRepository = new SizeDataIRepository<SizeData>(new Webb4Context());
        GenericRepository<SizeData> _genericRepository = new GenericRepository<SizeData>(new Webb4Context());

        public  IEnumerable<SizeViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<SizeData>, IEnumerable<SizeViewModel>>(getData);
            return randomItem;
        }

        public  async Task<SizeViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<SizeData, SizeViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(SizeViewModel adress)
        {
            var addMap = Mapper.Map<SizeViewModel, SizeData>(adress);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(SizeViewModel adress)
        {
            var editMap = Mapper.Map<SizeViewModel, SizeData>(adress);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
