using MediatR;
using OW.IntelliVending.DataReader;
using OW.IntelliVending.Entities;
using OW.IntelliVending.Service.Dtos;
using OW.IntelliVending.Service.Mappings;
using OW.IntelliVending.Service.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OW.IntelliVending.Service.Handler
{
    public class GetItemsHandler : IRequestHandler<GetItemsQuery, IList<VTransactionDto>>
    {
        private readonly IGenericRepository<VTransaction> _jsonRepository;
        
        private ItemDxos _itemDxos;

        public GetItemsHandler()
        {
            _jsonRepository = new JsonRepository();
        }

        public async Task<IList<VTransactionDto>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            List<VTransactionDto> Items = new List<VTransactionDto>();
            _itemDxos = new ItemDxos(request.AudRate);

            // read json data
            var transactions = _jsonRepository.GetAll();

            foreach (var item in transactions)
            {
                Items.Add(_itemDxos.MapTransactionItemToDto(item));
            }

            return Items;
        }
    }
}
