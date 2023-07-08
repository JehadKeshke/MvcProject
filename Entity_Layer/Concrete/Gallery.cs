﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Gallery
    {
        [Key]
        public int ImageID { get; set; }

        [StringLength(100)]
        public string ImageName  { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }
    }
}
