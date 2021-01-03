using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.DTO.Interfaces;

namespace BlogProjem.DTO.DTOs.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
    }
}
