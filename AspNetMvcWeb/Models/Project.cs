using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcWeb.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Display(Name = "Project Name")]
        [StringLength(12)]
        public string Name { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        [StringLength(2)]
        public string Rating { get; set; }
    }
}
