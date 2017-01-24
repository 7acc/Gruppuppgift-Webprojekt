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
        static AreaDataModelIRepository<AreaData> _areaRepository = new AreaDataModelIRepository<AreaData>(new Webb4Context());

        public static IEnumerable<AreaViewModel> FromBltoUiGetAll()
        {
            var getData = _areaRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<AreaData>, IEnumerable<AreaViewModel>>(getData);
            return randomItem;
        }

        public static async Task<AreaViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _areaRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<AreaData, AreaViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(AreaViewModel area)
        {
            var addMap = Mapper.Map<AreaViewModel, AreaData>(area);
            await _areaRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(AreaViewModel area)
        {
            var editMap = Mapper.Map<AreaViewModel, AreaData>(area);
            await _areaRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _areaRepository.GetByIdAsync(id);
            await _areaRepository.DeleteAsync(getFromR);

        }
    }
}
