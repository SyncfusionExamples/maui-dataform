using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexItemsSourceSample
{
    internal class ComplexItemsSourceModel
    {
        public int? ComboBox { get; set; }

        public int? AutoComplete { get; set; }

        public int? Picker { get; set; }

        public int? RadioGroup { get; set; }
    }

    public class ComplexModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
