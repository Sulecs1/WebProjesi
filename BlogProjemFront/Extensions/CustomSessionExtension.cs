using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BlogProjemFront.Extensions{
    public static class CustomSessionExtension{
        public static void SetObject(this ISession session,string key,object value){
          var JsonData= JsonConvert.SerializeObject(value);
          session.SetString(key,JsonData);
        }
        public static T GetObject<T>(this ISession session, string key)where T:class,new(){
            var data=session.GetString(key);
            if(string.IsNullOrWhiteSpace(data)){
                return null;
            }
           return JsonConvert.DeserializeObject<T>(data);

        }

    }
}