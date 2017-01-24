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
        static AppartmentPhotoDataModelRepository<ApartmentPhotoData> _appartmentPhotoRepository = new AppartmentPhotoDataModelRepository<ApartmentPhotoData>(new Webb4Context());

        public static IEnumerable<ApartmentPhotoViewModel> FromBltoUiGetAll()
        {
            var getData = _appartmentPhotoRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<ApartmentPhotoData>, IEnumerable<ApartmentPhotoViewModel>>(getData);
            return randomItem;
        }

        public static async Task<ApartmentPhotoViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _appartmentPhotoRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<ApartmentPhotoData, ApartmentPhotoViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(ApartmentPhotoViewModel appart)
        {
            var addMap = Mapper.Map<ApartmentPhotoViewModel, ApartmentPhotoData>(appart);
            await _appartmentPhotoRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(ApartmentPhotoViewModel appart)
        {
            var editMap = Mapper.Map<ApartmentPhotoViewModel, ApartmentPhotoData>(appart);
            await _appartmentPhotoRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _appartmentPhotoRepository.GetByIdAsync(id);
            await _appartmentPhotoRepository.DeleteAsync(getFromR);

        }
    }
}
