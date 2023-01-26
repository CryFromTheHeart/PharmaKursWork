using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaKursWork.Models
{
    public class LaboratoryEmployee
    {
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Укажите имя")]
        public string FirstName { get; set; } = string.Empty;

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Укажите фамилию")]
        public string LastName { get; set; } = string.Empty;

        [DisplayName("Номер телефон")]
        [Required(ErrorMessage = "Укажите номер телефона")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DisplayName("Email")]
        [Required(ErrorMessage = "Укажите email")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Адрес")]
        [Required(ErrorMessage = "Укажите адрес")]
        public string Adress { get; set; } = string.Empty;

        [DisplayName("Название лаборатории")]
        [Required(ErrorMessage = "Укажите название лаборатории")]
        public int LabratoryId { get; set; }

        [ForeignKey(nameof(LabratoryId))]
        public Laboratory Laboratory { get; set; }
    }
}
