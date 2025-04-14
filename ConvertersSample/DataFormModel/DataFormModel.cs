using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConvertersSample
{
    public class DataFormModel
    {
        [DataFormValueConverter(typeof(StringToDateTimeConverter))]
        [DataType(DataType.Date)]
        public string? DateTime { get; set; }
    }
}
