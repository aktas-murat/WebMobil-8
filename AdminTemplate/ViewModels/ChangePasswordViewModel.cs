
using System.ComponentModel.DataAnnotations;

namespace AdminTemplate.ViewModels
{
    public class ChangePasswordViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Mevcut Şifre")]
        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        public string CurrentPassword { get; set; }


        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Yeni Şifre")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni Şifre Tekrar")]
        [Compare(nameof(NewPassword), ErrorMessage = "Girdiğiniz bilgiler hatalıdır")]
        public string ConfirmNewPassword { get; set; }



    }
}