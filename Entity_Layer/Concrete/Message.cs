using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [StringLength(50)]
        public string  SenderMail { get; set; }

        [StringLength(50)]
        public string  ReciverMail { get; set; }

        [StringLength(100)]
        public string  Subject { get; set; }

        public string  Content { get; set; }
        public DateTime MessageDate { get; set; }

        public bool IsReading { get; set; }
    }
}
