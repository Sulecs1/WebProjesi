using System.Threading.Tasks;
using BlogProjemFront.Models;

namespace BlogProjemFront.ApiService.Interfaces{
    public interface IAuthApiService{
        Task<bool> SignIn(AppUserLoginModel model);
    }
}