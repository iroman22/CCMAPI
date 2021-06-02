using System;
namespace api.Models.Traffic
{
    public class Remesa
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public DateTime Fecha_Gestion { get; set; }
        public int GestionId { get; set; }
        public Gestion Gestiones { get; set; }
    }
}