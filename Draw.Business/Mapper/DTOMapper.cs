using AutoMapper;
using Draw.Core.DTOs;
using Draw.Core.Entity;
using static System.Net.Mime.MediaTypeNames;

namespace Draw.Business.Mapper;

internal class DTOMapper : Profile
{
	public DTOMapper()
	{
		CreateMap<MainTitleDTO, MainTitle>().ReverseMap();
		CreateMap<BaseTitleDTO, BaseTitle>().ReverseMap();
		CreateMap<SubTitleDTO, SubTitle>().ReverseMap();
	}
}
