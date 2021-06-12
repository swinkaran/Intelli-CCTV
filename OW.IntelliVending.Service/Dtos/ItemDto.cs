using System;
using System.Collections.Generic;
using System.Text;

namespace OW.IntelliVending.Service.Dtos
{
    public class ItemDto
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}
