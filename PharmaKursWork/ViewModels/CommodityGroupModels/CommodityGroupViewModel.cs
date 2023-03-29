using PharmaKursWork.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PharmaKursWork.ViewModels.CommodityGroupModels
{
    public class CommodityGroupViewModel
    {
        public CommodityGroupCustomModel CommodityGroupCustomModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public List<CommodityGroup> List { get; set; }
    }

    public class CommodityGroupCustomModel
    {
        public int Id { get; set; }
        
        [DisplayName("Название товарной группы")]
        [Required(ErrorMessage = "Укажите название товарной группы")]
        public string Name { get; set; }
        
        [DisplayName("Описание")]
        [Required(ErrorMessage = "Укажите описание")]
        public string Desc { get; set; }
    }

    public class FilterViewModel
    {
        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
