using AutoMapper;
using BasicAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAPI.Profiles
{
    public class AuthorsProfile: Profile
    {
        public AuthorsProfile()
        {
            CreateMap<CourseLibrary.API.Entities.Author, Models.AuthorDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<Models.AuthorCreationDto, CourseLibrary.API.Entities.Author>();
        }
    }
}
