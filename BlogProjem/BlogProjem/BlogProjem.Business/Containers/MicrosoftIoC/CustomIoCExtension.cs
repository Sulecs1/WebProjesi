using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using BlogProjem.Business.Concrete;
using BlogProjem.Business.Interfaces;
using BlogProjem.Business.Tools.JWTTool;
using BlogProjem.Business.Tools.LogTool;
using BlogProjem.Business.ValidationRules.FluentValidation;
using BlogProjem.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogProjem.DataAccess.Interfaces;
using BlogProjem.DTO.DTOs.AppUserDtos;
using BlogProjem.DTO.DTOs.CategoryBlogDtos;
using BlogProjem.DTO.DTOs.CategoryDtos;
using BlogProjem.DTO.DTOs.CommentDtos;

namespace BlogProjem.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            services.AddScoped<ICustomLogger, NLogAdapter>();


            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();


        }
    }
}
