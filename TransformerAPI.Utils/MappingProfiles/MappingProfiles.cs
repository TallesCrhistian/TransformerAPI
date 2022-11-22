using AutoMapper;
using TransformerAPI.Entities;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.ModelView;
using TransformerAPI.Shared.ModelView.UserModelView;
using TransformerAPI.Shared.ViewModel.TestViewModel;
using TransformerAPI.Shared.ViewModel.TransformerViewModel;
using TransformerAPI.Shared.ViewModel.UserViewModel;

namespace TransformerAPI.Utils.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<UserViewModeICreate, UserDTO>()
                .ReverseMap();
            CreateMap<UserViewModelUpdate, UserDTO>()
                .ReverseMap();
            CreateMap<UserViewModel, UserDTO>()
                .ReverseMap();
            CreateMap<UserDTO, User>()
                .ReverseMap();

            CreateMap<TransformerViewModelCreate, TransformerDTO>()
                .ReverseMap();
            CreateMap<TransformerViewModelUpdate, TransformerDTO>()
                .ReverseMap();
            CreateMap<TransformerViewModel, TransformerDTO>()
                .ReverseMap();
            CreateMap<TransformerDTO, Transformer>()
                .ReverseMap();

            CreateMap<TestViewModelCreate, TestDTO>()
                .ReverseMap();
            CreateMap<TestViewModelUpdate, TestDTO>()
                .ReverseMap();
            CreateMap<TestViewModel, TestDTO>()
                .ReverseMap();
            CreateMap<TestDTO, Test>()
                .ReverseMap();
        }
    }
}
