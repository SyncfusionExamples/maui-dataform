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
            this.ContactInfo = new ContactInfo();
        }

        public ContactInfo ContactInfo { get; set; }
    }
}
