using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTML_Helpers.Models
{
    public class Datos
    {
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        [Range(15, 99, ErrorMessage = "DEBE SER MAYOR O IGUAL QUE 15")]
        public int Edad { get; set; }

        public string Telefono { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        public Gender Genero { get; set; }

        public enum Gender
        {
            Masculino,
            Femenino
        }

        public string Estado { get; set; }

        public bool Hobby1 { get; set; }

        public bool Hobby2 { get; set; }

        public bool Hobby3 { get; set; }

        public bool Hobby4 { get; set; }



    }
}