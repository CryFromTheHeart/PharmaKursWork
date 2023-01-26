using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaKursWork.Models
{
    public class TechStaff
    {
        [Key]
        public int LaboratoryEmployeeId { get; set; }

        [DisplayName("Обслуживает прибор")]
        [Required(ErrorMessage = "Укажите какой прибор обслуживается")]
        public string MaintainsDevice { get; set; }

        [DisplayName("Есть ли свои инструменты")]
        [Required(ErrorMessage = "Укажите есть ли инструменты")]

        public bool HasYourInstruments { get; set; }
        [ForeignKey(nameof(LaboratoryEmployeeId))]
        public LaboratoryEmployee laboratoryEmployee { get; set; }
    }
}
