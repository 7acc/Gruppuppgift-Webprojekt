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
    public class UserDataMapping
    {
        static UserRepository<UserData> _userRepository = new UserRepository<UserData>(new Webb4Context());

        public static IEnumerable<UserDataViewModel> FromBltoUiGetAll()
        {
            var getData = _userRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<UserData>, IEnumerable<UserDataViewModel>>(getData);
            return randomItem;
        }

        public static async Task<UserDataViewModel> FromBltoUiGetById(Guid id)
        {
            var getRepo = await _userRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<UserData, UserDataViewModel>(getRepo);
            return detailsId;
        }

        public static async Task FromBltoUiInser(UserDataViewModel user)
        {
            var addMap = Mapper.Map<UserDataViewModel, UserData>(user);
            await _userRepository.InsertAsync(addMap);

        }

        public static async Task FromBltoUiEditAsync(UserDataViewModel user)
        {
            var editMap = Mapper.Map<UserDataViewModel, UserData>(user);
            await _userRepository.EditAsync(editMap);

        }

        public static async Task FromBltoUiDeleteAsync(Guid id)
        {
            var getFromR = await _userRepository.GetByIdAsync(id);
            await _userRepository.DeleteAsync(getFromR);

        }
    }
}
