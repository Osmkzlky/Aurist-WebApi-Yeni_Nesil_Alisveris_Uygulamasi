using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ecommerce_app.DTOs.Account
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "İsim gereklidir.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Soyisim gereklidir.")]
        public string Surname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefon numarası gereklidir.")]
        [RegularExpression(@"^(\+90|0)?5\d{9}$", ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-posta gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; } = string.Empty;
    }
}