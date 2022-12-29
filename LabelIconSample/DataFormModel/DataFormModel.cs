using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelIconSample
{
    public class DataFormModel
    {
        [Display(Prompt ="Enter your name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Prompt ="Enter you address")]
        public string Address { get; set; }

        [Display(Prompt ="Enter your number")]
        public string Phone { get; set; }

        [Display(Prompt ="Enter your email ")]
        public string Email { get; set; }
    }
}
