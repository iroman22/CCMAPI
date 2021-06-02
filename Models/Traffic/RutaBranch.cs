using System.Collections.Generic;

namespace api.Models.Traffic
{
    public class RutaBranch
    {
         public int RutaId { get; set; }
         public Ruta Rutas { get; set; }

         public int BranchId { get; set; }
         public Branch Branches { get; set; }
    }
}