using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public int AboutDetails1 { get; set; }
        public int AboutDetails2 { get; set; }
        public int AboutImage1 { get; set; }
        public int AboutImage2 { get; set; }
        public int AboutMaplocations { get; set; }
        public bool AboutStatus { get; set; }
    }
}
