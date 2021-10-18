using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace ProyPeliculas.Shared.Entity
{
    public class Movie
    {
        public int Id {get;set;}
        [Required(errorMessage="El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        public string Name {get;set;}
        [Required(errorMessage="El campo {0} es requerido")]
        public iDateTime? Premier {get;set;}        
        public list <CategoryMovie> CategoriesMovie {get;set;} =  new list<CategoryMovie>();
    }
}