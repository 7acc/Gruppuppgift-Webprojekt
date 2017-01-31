using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels2.VyModels;
using Webb4_DAL;
using Webb4_DAL.ModelsV2;
using Webb4_DAL.Repositories;

namespace Webb4_businesslayer.HelpMapper
{
   public class AppartmentPhotoMapping
    {
        // AppartmentPhotoDataModelRepository<AppartmentPhoto> _genericRepository = new AppartmentPhotoDataModelRepository<AppartmentPhoto>(new Webb4Context());
        GenericRepository<AppartmentPhoto> _genericRepository = new GenericRepository<AppartmentPhoto>(new Webb4Context());
        public  IEnumerable<AppartmentPhotoViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<AppartmentPhoto>, IEnumerable<AppartmentPhotoViewModel>>(getData);
            return randomItem;
        }

        public  async Task<AppartmentPhotoViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<AppartmentPhoto, AppartmentPhotoViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(AppartmentPhotoViewModel appart)
        {
            var addMap = Mapper.Map<AppartmentPhotoViewModel, AppartmentPhoto>(appart);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(AppartmentPhotoViewModel appart)
        {
            var editMap = Mapper.Map<AppartmentPhotoViewModel, AppartmentPhoto>(appart);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
