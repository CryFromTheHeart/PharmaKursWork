using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaKursWork.Models
{
    public class Scientist 
    {
        [Key]
        public int LaboratoryEmployeeId { get; set; }

        [DisplayName("Работает за прибором")]
        [Required(ErrorMessage = "Укажите прибор")]
        public string ResponsibleForDevice { get; set; }

        [DisplayName("Направление изучений")]
        [Required(ErrorMessage = "Укажите адрес лаборатории")]
        public string DirectionDevelopment { get; set; }
        [ForeignKey(nameof(LaboratoryEmployeeId))]
        public LaboratoryEmployee laboratoryEmployee { get; set; }
    }
}
