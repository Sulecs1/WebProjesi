using System.ComponentModel.DataAnnotations;

namespace BlogProjemFront.Models{

    public class CategoryUpdateModel{


        public int Id { get; set; }
        [Required(ErrorMessage="Ad alanı boş geçilmez")]
        [Display(Name="Ad :")]
        public string Name{get;set;}
    }
}