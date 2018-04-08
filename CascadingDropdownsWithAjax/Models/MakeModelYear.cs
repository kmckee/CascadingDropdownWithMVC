using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropdownsWithAjax.Models
{
    public class MakeModelYear
    {
        public MakeModelYear(int id, string year, string make, string model)
        {
            Id = id;
            Year = year;
            Make = make;
            Model = model;
        }
        public int Id { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}