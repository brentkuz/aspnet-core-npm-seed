using ASPCoreNPMSeed.Utility.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreNPMSeed.Models.Home
{
    public class IndexViewModel : ViewModelBase
    {
        //config
        [ClientConfiguration]
        public string ConfigValue1 { get; set; }
        [ClientConfiguration]
        public int ConfigValue2 { get; set; }
    }
}
