using StudentsJournalCore.DTOService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsJournalCore.DTOService.Services.Users
{
    public interface IUsersService
    {
        Task CreateNewUser(UserDTO user);
        Task<List<UserDTO>> GetAllUsers();
        Task<UserDTO> GetUserById(int id);
        Task UpdateUser(UserDTO user);
        Task DeleteUserById(int id);
    }
}
