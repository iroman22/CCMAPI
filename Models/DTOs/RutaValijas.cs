using System.ComponentModel.DataAnnotations.Schema;
namespace api.Models.DTOs
{
    public class RutaValijas
    {
        public int Id { get; set; }
        public string CodigoRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Peso_Excedente { get; set; }
        public string CodigoValija { get; set; }
        public int RutaId { get; set; }
    }
}