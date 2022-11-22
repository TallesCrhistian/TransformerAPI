using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.ModelView;

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
        [Route(nameof(Insert))]
        public async Task<IActionResult> Insert([FromBody] UserlViewModeInsert userViewModelInsert)
        {
            UserDTO userDTO = _mapper.Map<UserDTO>(userViewModelInsert);
            ServiceResponseDTO<UserDTO> serviceResponseDTO = await _userServices.Insert(userDTO);
            return Ok(serviceResponseDTO);
        }
    }
}
