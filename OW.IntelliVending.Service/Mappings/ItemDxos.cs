using AutoMapper;
using OW.IntelliVending.Entities;
using OW.IntelliVending.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OW.IntelliVending.Service.Mappings
{
    public class ItemDxos
    {
        private readonly IMapper _MegacorpMapper;
      
        public ItemDxos(decimal audRate)
        {
            //mapping for json
            var configMegacorpItem = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VTransaction, VTransactionDto>()
                .ForMember(dst => dst.TransactionId, opt => opt.MapFrom(src => src.TransactionId))
                .ForMember(dst => dst.Item, opt => opt.MapFrom(src => src.Item))
                .ForMember(dst => dst.Machine, opt => opt.MapFrom(src => src.Machine))
                .ForMember(dst => dst.Notes, opt => opt.MapFrom(src => src.Notes))
                .ForMember(dst => dst.Cost, opt => opt.MapFrom(src => (decimal.Parse(src.Cost.ToString()))
                ));
            });

            _MegacorpMapper = configMegacorpItem.CreateMapper();

            //mapping for csv

        }

        public VTransactionDto MapTransactionItemToDto(VTransaction item)
        {
            return _MegacorpMapper.Map<VTransaction, VTransactionDto>(item);
        }

    }
}
