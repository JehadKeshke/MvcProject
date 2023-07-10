using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }

        public int SkillRatio { get; set; }

        [StringLength(30)]
        public string  SkillName  { get; set; }
    }
}
