using Microsoft.AspNetCore.Mvc.Rendering;
using PharmaKursWork.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaKursWork.ViewModels.LaboratoryEmployeeViewModels
{
    public class LaboratoryEmployeeViewModel
    {
        public List<ScientistViewModel> ScientistList { get; set; }

        public ScientistViewModel ScientistViewModel{ get; set; }

        public List<TechStaffViewModel> TechStaffList { get; set; }

        public TechStaffViewModel TechStaffViewModel { get; set; }

        public SelectList LaboratorySelectList { get; set; }
    }

    public class ScientistViewModel
    {
        
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Укажите имя")]
        public string FirstName { get; set; } = string.Empty;

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Укажите фамилию")]
        public string LastName { get; set; } = string.Empty;

        [DisplayName("День рождения")]
        [Required(ErrorMessage = "Укажите день рождения")]
        public DateTime BirthDate { get; set; } 

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
        public string LaboratoryName { get; set; } = string.Empty;

        [DisplayName("Работает за прибором")]
        [Required(ErrorMessage = "Укажите прибор")]
        public string ResponsibleForDevice { get; set; } = string.Empty;

        [DisplayName("Направление изучений")]
        [Required(ErrorMessage = "Укажите адрес лаборатории")]
        public string DirectionDevelopment { get; set; } = string.Empty;
    }
    public class TechStaffViewModel
    {
        public int Id { get; set; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Укажите имя")]
        public string FirstName { get; set; } = string.Empty;

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Укажите фамилию")]
        public string LastName { get; set; } = string.Empty;

        [DisplayName("День рождения")]
        [Required(ErrorMessage = "Укажите день рождения")]
        public DateTime BirthDate { get; set; } 

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
        public string LaboratoryName { get; set; } = string.Empty;

        [DisplayName("Обслуживает прибор")]
        [Required(ErrorMessage = "Укажите какой прибор обслуживается")]
        public string MaintainsDevice { get; set; } = string.Empty;

        [DisplayName("Есть ли свои инструменты")]
        [Required(ErrorMessage = "Укажите есть ли инструменты")]
        public bool HasYourInstruments { get; set; } 
    }

}
