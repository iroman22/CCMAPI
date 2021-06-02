using System.Collections.Generic;
using System;
namespace api.Models.Traffic
{
    public class Branch
    {

        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Gerente { get; set; }

        public string Created_By { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora_Visita { get; set; }

        public int ClienteId { get; set; }
        public Cliente Clientes { get; set; }


    }
}