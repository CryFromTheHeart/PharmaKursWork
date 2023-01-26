﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PharmaKursWork.Models;

namespace PharmaKursWork.ViewModels.LaboratoryEmployeeViewModels
{
    public class AddScientistViewModel
    {
        public LaboratoryEmployee LaboratoryEmployeeModel { get; set; }
        public Models.Scientist ScientistModel { get; set; }
        public SelectList LaboratorySelectList { get; set; }
    }
}
