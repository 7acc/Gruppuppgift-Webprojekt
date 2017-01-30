using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels.VyModels;
using Webb4_DAL.Repositories;
using Webb4_DAL.Models;
using Webb4_DAL;

namespace Webb4_businesslayer.HelpMapper
{
    public class ApartmentMapping
    {
        // AppartmentDataModelRepository<ApartmentData> _genericRepository = new AppartmentDataModelRepository<ApartmentData>(new Webb4Context());
        GenericRepository<ApartmentData> _genericRepository = new GenericRepository<ApartmentData>(new Webb4Context());

        public  List<ApartmentViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll();
            var randomItem = Mapper.Map<List<ApartmentData>, List<ApartmentViewModel>>(new List<ApartmentData>(getData));
            return randomItem;
        }

        public  async Task<ApartmentViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<ApartmentData, ApartmentViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(ApartmentViewModel Appart)
        {
            var addMap = Mapper.Map<ApartmentViewModel, ApartmentData>(Appart);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(ApartmentViewModel Appart)
        {
            var editMap = Mapper.Map<ApartmentViewModel, ApartmentData>(Appart);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
