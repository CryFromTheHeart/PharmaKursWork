using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Укажите имя")]
        [MinLength(3, ErrorMessage = "Имя должно иметь длину больше 3 символов")]
        [MaxLength(20, ErrorMessage = "Имя должно иметь длину меньше 20 символов")]
        public string Username { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен иметь длину больше 6 символов")]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
