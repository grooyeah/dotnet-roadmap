using TaskManagerAPI.Models.DTOs;

namespace TaskManagerAPI.Interfaces
{
    public interface IUserService
    {
        Task<bool> Register(UserRegisterDto dto);
        Task<string?> Login(UserLoginDto dto);
    }
}
