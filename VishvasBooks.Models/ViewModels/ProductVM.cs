﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VishvasBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } //Displays all the products details

        public IEnumerable<SelectListItem> CategoryList { get; set; } //install the pakage "MS. Aspcore.Mvc.Rendering"
        public IEnumerable<SelectListItem> CoverTypeList { get; set; } //install the pakage "MS. Aspcore.Mvc.Rendering"

    }
}