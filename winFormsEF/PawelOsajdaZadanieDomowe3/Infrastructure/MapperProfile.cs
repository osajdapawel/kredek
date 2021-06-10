using AutoMapper;
using PawelOsajdaZadanieDomowe3.Models.Entities;
using PawelOsajdaZadanieDomowe3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Infrastructure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Laptop, LaptopViewModel>()
                .ForMember(p => p.ProcessorModel,           l => l.MapFrom(src => src.Processor.Model))
                .ForMember(p => p.ProcessorNumberOfThreads, l => l.MapFrom(src => src.Processor.NumberOfThreds))
                .ForMember(p => p.GraphicsCardModel,        l => l.MapFrom(src => src.GraphicsCard.Model))
                .ForMember(p => p.GraphicsVRamAmount,       l => l.MapFrom(src => src.GraphicsCard.VRamAmount));

            CreateMap<Suborder, SuborderViewModel>()
                .ForMember(p => p.LaptopModel, s => s.MapFrom(src => src.Laptop.Model))
                .ForMember(p => p.LaptopPrice, s => s.MapFrom(src => src.Laptop.Price))
                .ForMember(p => p.Sum, s => s.MapFrom(src => (src.Quantity * src.Laptop.Price)));
                
        }

    }
}