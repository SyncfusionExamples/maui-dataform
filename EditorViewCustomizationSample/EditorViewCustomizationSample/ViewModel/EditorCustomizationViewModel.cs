using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorViewCustomizationSample
{
    public class EditorCustomizationViewModel
    {
        public EditorCustomizationModel EditorCustomizationModel { get; set; }

        public EditorCustomizationViewModel()
        {
            this.EditorCustomizationModel = new EditorCustomizationModel();
        }
    }
}
