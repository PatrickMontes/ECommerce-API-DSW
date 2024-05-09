﻿using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Ingrese su nombre de la categoria")]
        public string? Nombre { get; set; }
    }
}