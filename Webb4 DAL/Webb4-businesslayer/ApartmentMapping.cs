using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using AutoMapper;
using ViewModels.VyModels;
using Webb4_DAL.Repositories;
using Webb4_DAL.Models;
using Webb4_DAL;

namespace Webb4_businesslayer
{
    public class ApartmentMapping
    {
        static AppartmentDataModelRepository<AppartmentDataModel> _appartmentRepository = new AppartmentDataModelRepository<AppartmentDataModel>(new Webb4Context());

        public static IEnumerable<AppartmentDataViewModel> FromBltoUiGetAll()
        {
            var getData = _appartmentRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<AppartmentDataModel>, IEnumerable<AppartmentDataViewModel>>(getData);
            return randomItem;
        }

        public static async Task<AppartmentDataViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _appartmentRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<AppartmentDataModel, AppartmentDataViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(AppartmentDataViewModel Appart)
        {
            var addMap = Mapper.Map<AppartmentDataViewModel, AppartmentDataModel>(Appart);
            await _appartmentRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(AppartmentDataViewModel Appart)
        {
            var editMap = Mapper.Map<AppartmentDataViewModel, AppartmentDataModel>(Appart);
            await _appartmentRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _appartmentRepository.GetByIdAsync(id);
            await _appartmentRepository.DeleteAsync(getFromR);

        }
    }
}
