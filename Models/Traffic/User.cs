using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.Traffic
{
    public class User
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Telefono_Casa { get; set; }

        public string Titulo { get; set; }

        public char Genero { get; set; }

        public int Edad { get; set; }

        [Column(TypeName = "decimal(5,2)")]

        public decimal Salario { get; set; }

        public DateTime Fecha_Contratacion { get; set; }

        public string Usuario { get; set; }

        public byte[] ContraHash { get; set; }

        public byte[] ContraSalt { get; set; }

        public char Tipo_Actor { get; set; }

        public char Certified { get; set; }

        public string Created_By { get; set; }

        public char Tipo_Sangre { get; set; }
        
    }
}