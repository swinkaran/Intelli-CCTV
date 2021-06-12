using System;
using System.Collections.Generic;
using System.Text;

namespace OW.IntelliVending.Service.Dtos
{
    public class VTransactionDto
    {
        public int TransactionId { get; set; }
        public string Item { get; set; }
        public decimal Cost { get; set; }
        public int Machine { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
    }
}
