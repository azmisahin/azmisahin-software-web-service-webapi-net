using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Todo.Models
{
    // AccountController eylemleri için parametre olarak kullanılan modeller.

    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "Dış erişim belirteci")]
        public string ExternalAccessToken { get; set; }
    }

    public class ChangePasswordBindingModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Geçerli parola")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni parola")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Yeni parolayı onayla")]
        [Compare("NewPassword", ErrorMessage = "Yeni parola ile onay parolası aynı değil.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterBindingModel
    {
        [Required]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Parolayı onaylayın")]
        [Compare("Password", ErrorMessage = "Parola ve onay parolası aynı değil.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "E-posta")]
        public string Email { get; set; }
    }

    public class RemoveLoginBindingModel
    {
        [Required]
        [Display(Name = "Oturum açma sağlayıcısı")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Sağlayıcı anahtarı")]
        public string ProviderKey { get; set; }
    }

    public class SetPasswordBindingModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni parola")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Yeni parolayı onayla")]
        [Compare("NewPassword", ErrorMessage = "Yeni parola ile onay parolası aynı değil.")]
        public string ConfirmPassword { get; set; }
    }
}
