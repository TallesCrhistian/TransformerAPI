using AutoMapper;
using System.Threading.Tasks;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserBusiness(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserDTO> Insert(UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            user = await _userRepository.Insert(user);
            return _mapper.Map<UserDTO>(user);
        }
    }
}
