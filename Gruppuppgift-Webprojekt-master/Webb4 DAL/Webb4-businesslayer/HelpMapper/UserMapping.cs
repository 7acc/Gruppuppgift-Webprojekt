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
    public class UserMapping
    {
        // UserRepository<User> _genericRepository = new UserRepository<User>(new Webb4Context());
        GenericRepository<User> _genericRepository = new GenericRepository<User>(new Webb4Context());

        public  IEnumerable<UserViewModel> FromBltoUiGetAll()
        {
            var getData = _genericRepository.GetAll().ToList();
            var randomItem = Mapper.Map<List<User>, IEnumerable<UserViewModel>>(getData);
            return randomItem;
        }

        public  async Task<UserViewModel> FromBltoUiGetById(int id)
        {
            var getRepo = await _genericRepository.GetByIdAsync(id);
            var detailsId = Mapper.Map<User, UserViewModel>(getRepo);
            return detailsId;
        }

        public  async Task FromBltoUiInser(UserViewModel user)
        {
            var addMap = Mapper.Map<UserViewModel, User>(user);
            await _genericRepository.InsertAsync(addMap);

        }

        public  async Task FromBltoUiEditAsync(UserViewModel user)
        {
            var editMap = Mapper.Map<UserViewModel, User>(user);
            await _genericRepository.EditAsync(editMap);

        }

        public  async Task FromBltoUiDeleteAsync(int id)
        {
            var getFromR = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(getFromR);

        }
    }
}
