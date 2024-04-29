using AdministratorWydarzen_WinForms.Dtos;
using AdministratorWydarzen_WinForms.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen_WinForms.MappingProfiles
{
    public class MainEventMappingProfile : Profile
    {
        public MainEventMappingProfile()
        {
            CreateMap<Event, DetailedEventDto>()
                .ForMember(e => e.EventTypeId, e => e.MapFrom(t => (int)t.EventType))
                .ForMember(e => e.EventPriorityId, e => e.MapFrom(p => (int)p.EventPriority));

            CreateMap<DetailedEventDto, Event>()
                .ForMember(e => e.EventType, e => e.MapFrom(t => (EventType)t.EventTypeId))
                .ForMember(e => e.EventPriority, e => e.MapFrom(t => (EventPriority)t.EventPriorityId));

            CreateMap<Event, BasicEventDto>()
                .ForMember(e => e.EventTypeId, e => e.MapFrom(t => (int)t.EventType))
                .ForMember(e => e.EventPriorityId, e => e.MapFrom(p => (int)p.EventPriority));
        }
    }
}
