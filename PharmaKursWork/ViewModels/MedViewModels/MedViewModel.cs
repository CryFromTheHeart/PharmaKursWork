using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace PharmaKursWork.ViewModels.MedViewModels
{
    public class MedCustomViewModel
    {
        [DisplayName("Раз")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Начало разработки")]
        public DateTime StartExploring { get; set; }

        [DisplayName("Конец разработки")]
        public DateTime EndExploring { get; set; }

        [DisplayName("Вклад")]
        public decimal Expenses { get; set; }

        [DisplayName("Лаборатория")]
        public string LabratoryName { get; set; }

        [DisplayName("Товарная группа")]
        public string CommodityName { get; set; }

        [DisplayName("Единица измерения")]
        public string UnitMeasureName { get; set; }
    }

    public class MedViewModel
    {
        public List<MedCustomViewModel> List { get; set; } = new List<MedCustomViewModel>();

        public MedCustomViewModel MedCustomViewModel { get; set; }

        public SelectList LaboratoryList { get; set; }
        
        public SelectList CommodityGroupsList { get; set; }
        
        public SelectList UnitMeasuresList { get; set; }

        public FilterViewModel FilterViewModel { get; set; }
    }

    public class FilterViewModel
    {

        [DisplayName("Минимальный вклад")]
        public decimal MinExpenses { get; set; }

        [DisplayName("Максимальный вклад")]
        public decimal MaxExpenses { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }        
    }
}
