using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PharmaKursWork.ViewModels.MedViewModels
{
    public class EditMedModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Укажите название")]
        public string Name { get; set; }

        [DisplayName("Начало разработки")]
        [Required(ErrorMessage = "Укажите начало разработки")]
        public DateTime StartExploring { get; set; }

        [DisplayName("Конец разработки")]
        [Required(ErrorMessage = "Укажите конец разработки")]
        public DateTime EndExploring { get; set; }

        [DisplayName("Вклад в разработку")]
        [Required(ErrorMessage = "Укажите вклад в разработку")]
        public decimal Expenses { get; set; }

        [DisplayName("Название лаборатории")]
        [Required(ErrorMessage = "Укажите название название лаборатории")]
        public int LabratoryId { get; set; }

        [DisplayName("Название товарной группы")]
        [Required(ErrorMessage = "Укажите название название товарной группы")]
        public int CommodityGroupId { get; set; }

        [DisplayName("Единица измерения")]
        [Required(ErrorMessage = "Укажите единицу измерения")]
        public int UnitMeasureId { get; set; }
    }

    public class EditMedModalViewModel
    {
        public EditMedModel EditMedModel { get; set; }
        public SelectList LaboratoryList { get; set; }

        public SelectList CommodityGroupsList { get; set; }

        public SelectList UnitMeasuresList { get; set; }
    }
}

