using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingLabelLayoutSample
{
    internal class FloatingLabelViewModel
    {
        public FloatingLabelViewModel() 
        {
            this.FloatingLabelModel = new FloatingLabelModel();
        }

        public FloatingLabelModel FloatingLabelModel { get; set; }
    }
}
