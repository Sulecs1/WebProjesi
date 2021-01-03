using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlogProjemFront.ApiService.Interfaces;
using BlogProjemFront.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BlogProjemFront.ApiService.Concrete{
    public class AuthApiManager : IAuthApiService{
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthApiManager(HttpClient httpClient,
        IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor=httpContextAccessor;
            _httpClient=httpClient;
            _httpClient.BaseAddress=new Uri("http://localhost:52395/api/Auth/");
        }
        public async Task<bool> SignIn(AppUserLoginModel model){
            var JsonData=JsonConvert.SerializeObject(model);
            var stringContent=new StringContent(JsonData,
            Encoding.UTF8,"application/json");
           var  responseMessage=  await _httpClient.PostAsync("SignIn",stringContent);
           if(responseMessage.IsSuccessStatusCode){
               var accesToken=JsonConvert.DeserializeObject<AccessToken>(await responseMessage.Content.ReadAsStringAsync());
               
               _httpContextAccessor.HttpContext.Session.SetString("token",accesToken.Token);
                return true;

           }
           return false;


        }
        
    }
}