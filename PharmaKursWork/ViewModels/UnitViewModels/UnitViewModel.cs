using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PharmaKursWork.Models;

namespace PharmaKursWork.ViewModels.UnitViewModels
{
    public class UnitViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Укажите название единицы изерения")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        [Required(ErrorMessage = "Укажите описание единицы изерения")]
        public string Desc { get; set; }

        public List<UnitMeasure> List { get; set; } = new List<UnitMeasure>();
    }
}
