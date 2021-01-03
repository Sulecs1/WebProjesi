using System.Threading.Tasks;

namespace BlogProjemFront.ApiService.Interfaces{
    public interface IImageApiService{
        Task<string> GetBlogImageByIdAsync(int id);
    }
}