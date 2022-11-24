using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.ModelView;
using TransformerAPI.Shared.ViewModel.UserViewModel;

namespace TransformerAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;

        public UserController(IUserServices userServices, IMapper mapper)
        {
            _userServices = userServices;
            _mapper = mapper;
        }
        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] UserViewModeICreate userViewModeICreate)
        {
            UserDTO userDTO = _mapper.Map<UserDTO>(userViewModeICreate);
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Create(userDTO);
            return Ok(serviceResponseDTO);
        }
        [HttpPut]
        [Route(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] UserViewModelUpdate userViewModelUpdate, string id)
        {
            UserDTO userDTO = _mapper.Map<UserDTO>(userViewModelUpdate);
            ServiceResponseDTO<UserDTO> ServiceResponseDTO = await _userServices.Update(userDTO, id);
            return Ok(ServiceResponseDTO);
        }
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Delete(id);
            return Ok(serviceResponseDTO);
        }
        [HttpPost("{id:length(24)}")]
        public async Task<IActionResult> ObterPorCodigo(string id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Read(id);
            return Ok(serviceResponseDTO);
        }
    }
}
