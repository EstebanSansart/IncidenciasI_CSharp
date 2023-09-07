using ApiIncidenciasI.Dtos;
using Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiIncidenciasI.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Area, AreaDto>.ReverseMap();
    }
}