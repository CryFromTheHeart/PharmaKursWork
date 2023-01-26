using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.UnitViewModels
{
    public class AddUnitModalViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Укажите название единицы изерения")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        [Required(ErrorMessage = "Укажите описание единицы изерения")]
        public string Desc { get; set; }
    }
}
