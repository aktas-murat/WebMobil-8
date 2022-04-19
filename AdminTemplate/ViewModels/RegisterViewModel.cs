using System.ComponentModel.DataAnnotations;

namespace AdminTemplate.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name="Kullanıcı Adı")]
        [Required(ErrorMessage="Kullanıcı adı alanı gerekiyor")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Ad alanı gerekiyor")]
        [Display(Name="Ad")]
        [StringLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyad alanı gerekiyor")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-Posta alanı gerekiyor")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre alanı gerekiyor")]
        [StringLength(100,MinimumLength =6,ErrorMessage ="Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre alanı gerekiyor")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
