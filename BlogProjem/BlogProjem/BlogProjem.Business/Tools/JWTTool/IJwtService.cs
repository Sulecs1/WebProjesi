using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
