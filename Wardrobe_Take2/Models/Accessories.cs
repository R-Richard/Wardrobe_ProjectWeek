using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wardrobe_Take2.Models
{
    public class Accessories
    {

        [Key]
        public int ID { get; set; }
        public string Nickname { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }

    }
}