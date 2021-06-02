using System;

namespace api.Models.Traffic
{
    public class Gestion
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public DateTime Fecha_Gestion { get; set; }

        public int ValijaId { get; set; }

        public Valija Valijas { get; set; }
    }
}