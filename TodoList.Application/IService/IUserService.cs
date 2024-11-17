using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Application.DTOs;

namespace TodoList.Application.IService
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetUsers();
        public Task<UserDTO> CreateUser(UserDTO user);
        public Task<UserDTO> UpdateUser(UserDTO user);
        public Task<bool> DeleteUser(Guid userId);
        public Task<UserDTO> GetUserById(Guid userId);
    }
}
