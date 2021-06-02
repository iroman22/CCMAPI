using System;

namespace api.Models.Traffic
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Validacion { get; set; }


        public string Created_By { get; set; }

        public DateTime Fecha { get; set; }

        public Boolean Exclusive_Db { get; set; }


    }
}