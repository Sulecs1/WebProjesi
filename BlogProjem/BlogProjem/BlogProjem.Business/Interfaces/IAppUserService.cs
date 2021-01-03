using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlogProjem.DTO.DTOs.AppUserDtos;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
