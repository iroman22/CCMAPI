namespace api.Models.Traffic
{
    public class RutaUsers
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string UserNombre { get; set; }
        public string UserApellido { get; set; }
        public int Tipo_Ruta { get; set; }
        public int UserId { get; set; }
        public int Turno { get; set; }
        public int Estado_Ruta { get; set; }
    }
}