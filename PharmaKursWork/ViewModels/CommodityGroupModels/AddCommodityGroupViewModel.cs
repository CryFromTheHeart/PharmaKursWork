using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PharmaKursWork.ViewModels.CommodityGroupModels
{
    public class AddCommodityGroupViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название товарной группы")]
        [Required(ErrorMessage = "Укажите название товарной группы")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        [Required(ErrorMessage = "Укажите описание")]
        public string Desc { get; set; }
    }
}
