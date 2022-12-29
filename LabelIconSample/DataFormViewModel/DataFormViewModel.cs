using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelIconSample
{
    public class DataFormViewModel
    {
        public DataFormModel DataFormModel { get; set; }

        public DataFormViewModel()
        {
            this.DataFormModel = new DataFormModel();
        }
    }
}
