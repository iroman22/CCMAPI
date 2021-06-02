using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.Traffic
{
    public class Valija
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Origen { get; set; }

        public string Destino { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Peso_Excedente { get; set; }

        public Boolean Estado_Valija { get; set; }

        public int RutaId { get; set; }
        public Ruta Rutas { get; set; }
    }
}