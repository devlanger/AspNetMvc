using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcWeb.Models
{
    public class ProjectCategoryViewModel
    {
        public List<Project> Projects { get; set; }
        public SelectList Categories { get; set; }
        public string CategoryString { get; set; }
        public string SearchString { get; set; }
    }
}
