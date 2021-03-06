﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OW.IntelliVending.Service.Dtos
{
    public class VMachineDto
    {
        public string MachineId { get; set; }

        public string Code { get; set; }
        public string Location { get; set; }
        public string ClientId { get; set; }
        public string InstalledOn { get; set; }
        public string IsACtive { get; set; }
    }
}
