using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model 
{
    public class Client 
    {
        [Key]
        public int id { get; set; }

        [Required, MaxLength(30)]
        public string primer_nombre { get; set; }

        [MaxLength(30)]
        public string segundo_nombre { get; set; }

        [Required, MaxLength(30)]
        public string primer_apellido { get; set; }

        [MaxLength(30)]
        public string segundo_apellido { get; set; }

        [Required, MaxLength(10)]
        public string tipo_doc { get; set; }

        [Required, MaxLength(15)]
        public string celular { get; set; }

        [Required, MaxLength(50)]
        public string direccion { get; set; }

        [Required, MaxLength(50)]
        public string correo { get; set; }
    }
}