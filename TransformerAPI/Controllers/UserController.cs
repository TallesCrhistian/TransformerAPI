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
        public async Task<IActionResult> Create([FromBody] UserlViewModeInsert userViewModelInsert)
        {
            UserDTO userDTO = _mapper.Map<UserDTO>(userViewModelInsert);
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Create(userDTO);
            return Ok(serviceResponseDTO);
        }
        [HttpPut]
        [Route(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] UserViewModelUpdate userViewModelUpdate)
        {
            UserDTO userDTO = _mapper.Map<UserDTO>(userViewModelUpdate);
            ServiceResponseDTO<UserDTO> ServiceResponseDTO = await _userServices.Update(userDTO);
            return Ok(ServiceResponseDTO);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Delete(id);
            return Ok(serviceResponseDTO);
        }
        [HttpPost("{id:int}")]
        public async Task<IActionResult> ObterPorCodigo(int id)
        {
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Read(id);
            return Ok(serviceResponseDTO);
        }
    }
}
