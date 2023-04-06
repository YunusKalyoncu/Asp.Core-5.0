using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen  Adını Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Soyadınızı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi  Giriniz")]
        
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen  Resim Url Değeri Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrarlayınız ")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
        public string Mail { get; set; }
    }
}
