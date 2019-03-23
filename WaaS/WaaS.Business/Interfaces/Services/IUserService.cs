using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WaaS.Business.Dtos;
using WaaS.Business.Dtos.User;

namespace WaaS.Business.Interfaces.Services
{
  public interface IUserService
  {
    Task<UserDto> CreateAsync(UserDto user);
    Task<UserDto> AuthenticateAsync(string userEmail, string password);
    Task<UserDto> UpdateEmailAsync(ClaimsPrincipal principal, string newEmail);
    Task<bool> UpdatePasswordAsync(ClaimsPrincipal principal, string currentPassword, string newPassword);
    Task<UserDto> DeleteAsync(ClaimsPrincipal principal);
  }
}
