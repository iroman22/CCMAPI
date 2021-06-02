using System;
using System.Collections.Generic;
namespace api.Models.Traffic
{
    public class Ruta
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public int Tipo_Ruta { get; set; }

        public int Turno { get; set; }

        public DateTime Hora_Visita { get; set; }

        public int Estado_Ruta { get; set; }

        public int UserId { get; set; }
        public User Users { get; set; }


        // public ICollection<Mensajero> Mensajeros { get; set; }
    }

}