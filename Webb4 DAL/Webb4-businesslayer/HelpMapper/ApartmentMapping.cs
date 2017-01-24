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

namespace Webb4_businesslayer.HelpMapper
{
    public class ApartmentMapping
    {
        static AppartmentDataModelRepository<ApartmentData> _appartmentRepository = new AppartmentDataModelRepository<ApartmentData>(new Webb4Context());

        public static IEnumerable<ApartmentViewModel> FromBltoUiGetAll()
        {
            var getData = _appartmentRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<ApartmentData>, IEnumerable<ApartmentViewModel>>(getData);
            return randomItem;
        }

        public static async Task<ApartmentViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _appartmentRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<ApartmentData, ApartmentViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(ApartmentViewModel Appart)
        {
            var addMap = Mapper.Map<ApartmentViewModel, ApartmentData>(Appart);
            await _appartmentRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(ApartmentViewModel Appart)
        {
            var editMap = Mapper.Map<ApartmentViewModel, ApartmentData>(Appart);
            await _appartmentRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _appartmentRepository.GetByIdAsync(id);
            await _appartmentRepository.DeleteAsync(getFromR);

        }
    }
}
