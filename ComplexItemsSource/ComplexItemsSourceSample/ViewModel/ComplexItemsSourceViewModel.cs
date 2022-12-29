using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComplexItemsSourceSample
{
    internal class ComplexItemsSourceViewModel
    {
        public ComplexItemsSourceViewModel() 
        {
            this.ComplexItemsSourceModel= new ComplexItemsSourceModel();
        }
        public ComplexItemsSourceModel ComplexItemsSourceModel { get; set; }
    }

    
}
