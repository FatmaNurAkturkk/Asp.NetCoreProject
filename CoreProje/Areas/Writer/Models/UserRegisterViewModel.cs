using System.ComponentModel.DataAnnotations;

namespace CoreProje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadını Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Url Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Parolayı Tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şiferler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresini Girin")]
        public string Mail { get; set; }
    }
}
