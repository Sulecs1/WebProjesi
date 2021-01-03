using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.DTO.Interfaces;

namespace BlogProjem.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
