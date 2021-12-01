using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApplication1.Model
{
    public class StudentModel
    {
        public string UserId { get; set; }
        [Required]
        [MinLength(2)]
        public string Lastname { get; set; }//j
        [Required]
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }

    }
}
