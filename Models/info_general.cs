using System.ComponentModel.DataAnnotations;

namespace wControlFinanciero.Models
{
    public class info_general
    {
        [Key]
        public int iidinfo_general { get; set; }
        public string cversion_bd { get; set; }
        public string cversion_software { get; set; }
        public DateTime dtvigencia { get; set; }
        public string ccliente { get; set; }
    }
}
