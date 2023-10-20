using System.ComponentModel.DataAnnotations;

namespace CoreProje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adını Giriniz...!")]
        public string Username { get; set; }
        [Display(Name ="Şifreyi Giriniz")]
        [Required(ErrorMessage =" Lütfen şifreyi Giriniz...!")]
        public string Password { get; set; }
    }
}
