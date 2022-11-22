using AutoMapper;
using TransformerAPI.Entities;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.ModelView;
using TransformerAPI.Shared.ModelView.UserModelView;

namespace TransformerAPI.Utils.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<UserlViewModeInsert, UserDTO>()
                .ReverseMap();
            CreateMap<UserViewModel, UserDTO>()
                .ReverseMap();
            CreateMap<UserDTO, User>()
                .ReverseMap();
        }
    }
}
