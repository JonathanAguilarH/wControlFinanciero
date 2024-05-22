using System.ComponentModel.DataAnnotations;

namespace wControlFinanciero.Models
{
    public class usuarios
    {
        [Key]
        public int id_usuario { get; set; }
        public string cpassword { get; set; }
        public string cpermisos { get; set; }
        public bool bactivo { get; set; }
    }
}
