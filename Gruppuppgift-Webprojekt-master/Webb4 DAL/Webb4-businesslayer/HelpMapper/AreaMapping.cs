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
    public class AreaMapping
    {
        // AreaDataModelIRepository<AreaData> _genericRepository = new AreaDataModelIRepository<AreaData>(new Webb4Context());
        GenericRepository<AreaData> _genericRepository = new GenericRepository<AreaData>(new Webb4Context());
        public  List<AreaViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<AreaData>, List<AreaViewModel>>(getData);
            return randomItem;
        }

        public  async Task<AreaViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<AreaData, AreaViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(AreaViewModel area)
        {
            var addMap = Mapper.Map<AreaViewModel, AreaData>(area);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(AreaViewModel area)
        {
            var editMap = Mapper.Map<AreaViewModel, AreaData>(area);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
