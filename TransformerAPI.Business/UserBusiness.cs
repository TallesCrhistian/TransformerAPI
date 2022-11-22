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
        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            user = await _userRepository.Create(user);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            user = await _userRepository.Update(user);
            return _mapper.Map<UserDTO>(user);
        }
        public async Task<UserDTO> Delete(int id)
        {
            User user = await _userRepository.Delete(id);
            UserDTO userDTO = (user != null) ? _mapper.Map<UserDTO>(user) : new UserDTO();
            return userDTO;
        }
        public async Task<UserDTO> Read(int id)
        {
            User user = await _userRepository.Read(id);
            UserDTO userDTO = (user != null) ? _mapper.Map<UserDTO>(user) : new UserDTO();
            return userDTO;
        }
    }
}
