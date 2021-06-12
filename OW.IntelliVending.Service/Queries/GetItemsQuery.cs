using MediatR;
using OW.IntelliVending.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OW.IntelliVending.Service.Queries
{
    public class GetItemsQuery :IRequest<IList<VTransactionDto>>
    {
        public GetItemsQuery(decimal audRate)
        {
            AudRate = audRate;
        }

        public decimal AudRate { get; set; }
    }
}
