using System;
using System.Collections.Generic;
using System.Text;

namespace OW.IntelliVending.Entities
{
    public class Partner
    {
        public string name { get; set; }
        public string partnerType { get; set; }

        public string partnerAddress { get; set; }

        public List<VTransaction> supplies { get; set; }
    }
}
