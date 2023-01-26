using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PharmaKursWork.Models;

namespace PharmaKursWork.ViewModels.LaboratoriesViewModels
{
    public class LaboratoriesViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название лаборатории")]
        [Required(ErrorMessage = "Укажите название лаборатории")]
        public string Name { get; set; }

        [DisplayName("Адрес лаборатории")]
        [Required(ErrorMessage = "Укажите адрес лаборатории")]
        public string Adress { get; set; }

        public List<Laboratory> List { get; set; } = new List<Laboratory>();
    }
}
