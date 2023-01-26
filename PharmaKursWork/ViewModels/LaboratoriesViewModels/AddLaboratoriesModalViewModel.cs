using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PharmaKursWork.ViewModels.LaboratoriesViewModels
{
    public class AddLaboratoriesModalViewModel
    {

        public int Id { get; set; }

        [DisplayName("Название лаборатории")]
        [Required(ErrorMessage = "Укажите название лаборатории")]
        public string Name { get; set; }

        [DisplayName("Адрес лаборатории")]
        [Required(ErrorMessage = "Укажите адрес лаборатории")]
        public string Adress { get; set; }
    }
}
