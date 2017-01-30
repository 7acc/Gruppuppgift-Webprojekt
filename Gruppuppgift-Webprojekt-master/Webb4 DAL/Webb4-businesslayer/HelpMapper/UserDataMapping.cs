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
        // UserRepository<UserData> _genericRepository = new UserRepository<UserData>(new Webb4Context());
        GenericRepository<UserData> _genericRepository = new GenericRepository<UserData>(new Webb4Context());

        public  IEnumerable<UserDataViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<UserData>, IEnumerable<UserDataViewModel>>(getData);
            return randomItem;
        }

        public  async Task<UserDataViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<UserData, UserDataViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(UserDataViewModel user)
        {
            var addMap = Mapper.Map<UserDataViewModel, UserData>(user);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(UserDataViewModel user)
        {
            var editMap = Mapper.Map<UserDataViewModel, UserData>(user);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
