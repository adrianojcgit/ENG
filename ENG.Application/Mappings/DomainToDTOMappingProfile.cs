using AutoMapper;
using Eng.Application.DTOs;
using Eng.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng.Application.Mappings
{
	public class DomainToDTOMappingProfile : Profile
	{
		public DomainToDTOMappingProfile()
		{
			CreateMap<Product, ProductDTO>().ReverseMap();
			CreateMap<Category, CategoryDTO>().ReverseMap();
		}
	}
}
