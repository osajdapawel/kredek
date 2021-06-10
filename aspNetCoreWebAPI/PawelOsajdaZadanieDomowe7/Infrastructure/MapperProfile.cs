using AutoMapper;
using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Infrastructure
{
    /// <summary>
    /// Klasa konfiguracji mappera
    /// </summary>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Konfiguracja mapppera
        /// </summary>
        public MapperProfile()
        {
            CreateMap<Laptop, LaptopDTO>()
                .ForMember(p => p.ProcessorModel,           l => l.MapFrom(src => src.Processor.Model))
                .ForMember(p => p.ProcessorNumberOfThreads, l => l.MapFrom(src => src.Processor.NumberOfThreds))
                .ForMember(p => p.GraphicsCardModel,        l => l.MapFrom(src => src.GraphicsCard.Model))
                .ForMember(p => p.GraphicsVRamAmount,       l => l.MapFrom(src => src.GraphicsCard.VRamAmount));               
        }

    }
}
