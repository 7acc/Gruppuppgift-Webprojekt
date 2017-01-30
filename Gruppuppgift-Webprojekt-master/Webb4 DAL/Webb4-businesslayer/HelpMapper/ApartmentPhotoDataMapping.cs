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
   public class ApartmentPhotoDataMapping
    {
        // AppartmentPhotoDataModelRepository<ApartmentPhotoData> _genericRepository = new AppartmentPhotoDataModelRepository<ApartmentPhotoData>(new Webb4Context());
        GenericRepository<ApartmentPhotoData> _genericRepository = new GenericRepository<ApartmentPhotoData>(new Webb4Context());
        public  IEnumerable<ApartmentPhotoViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<ApartmentPhotoData>, IEnumerable<ApartmentPhotoViewModel>>(getData);
            return randomItem;
        }

        public  async Task<ApartmentPhotoViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<ApartmentPhotoData, ApartmentPhotoViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(ApartmentPhotoViewModel appart)
        {
            var addMap = Mapper.Map<ApartmentPhotoViewModel, ApartmentPhotoData>(appart);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(ApartmentPhotoViewModel appart)
        {
            var editMap = Mapper.Map<ApartmentPhotoViewModel, ApartmentPhotoData>(appart);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
