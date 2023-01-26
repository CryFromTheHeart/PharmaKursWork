using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Укажите имя")]
        public string Username { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        public string Password { get; set; } = string.Empty;

    }
}
