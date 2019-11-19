using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using musicmanager.Enums;

namespace musicmanager.Models
{
    public class Author
    {
    
        public Guid Id { get; set; }=Guid.NewGuid();
     //   [Required(ErrorMessage = "Este campo é obrigatório")]
    //    [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
     //   [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Name { get; set; }
  //      [Required(ErrorMessage = "Este campo é obrigatório")]
     //   [MinLength(6, ErrorMessage = "Este campo deve conter entre 6 caracteres")]
  ///      [MaxLength(6, ErrorMessage = "Este campo deve conter entre 6 caracteres")]
        public string Code { get; set; }
    //    [Required(ErrorMessage = "Este campo é obrigatório")]
        public ECategoryAuthor Category { get; set; }
        public virtual List<MusicAuthor> MusicAuthors { get;  set; }
    }
}