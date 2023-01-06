using System.ComponentModel.DataAnnotations;

namespace ToastNotification.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
    }
}
