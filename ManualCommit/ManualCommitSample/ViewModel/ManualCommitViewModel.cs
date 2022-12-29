using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualCommitSample
{
    internal class ManualCommitViewModel
    {
        public ManualCommitViewModel()
        {
            this.ManualCommitModel = new ManualCommitModel();
        }

        public ManualCommitModel ManualCommitModel { get; set; }
    }
}
