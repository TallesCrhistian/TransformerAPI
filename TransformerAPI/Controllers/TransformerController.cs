using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.ViewModel.TransformerViewModel;

namespace TransformerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransformerController : ControllerBase
    {
        private readonly ITransformerServices _transformerServices;
        private readonly IMapper _mapper;

        public TransformerController(ITransformerServices transformerServices, IMapper mapper)
        {
            _transformerServices = transformerServices;
            _mapper = mapper;
        }
        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] TransformerViewModelCreate transformerViewModelCreate)
        {
            TransformerDTO transformerDTO = _mapper.Map<TransformerDTO>(transformerViewModelCreate);
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = await _transformerServices.Create(transformerDTO);
            return Ok(serviceResponseDTO);
        }
        [HttpPut]
        [Route(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] TransformerViewModelUpdate transformerViewModelUpdate , string id)
        {
            TransformerDTO transformerDTO = _mapper.Map<TransformerDTO>(transformerViewModelUpdate);
            ServiceResponseDTO<TransformerDTO> ServiceResponseDTO = await _transformerServices.Update(transformerDTO, id);
            return Ok(ServiceResponseDTO);
        }
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = await _transformerServices.Delete(id);
            return Ok(serviceResponseDTO);
        }
        [HttpPost("{id:length(24)}")]
        public async Task<IActionResult> ObterPorCodigo(string id)
        {
            ServiceResponseDTO<TransformerDTO> serviceResponseDTO = await _transformerServices.Read(id);
            return Ok(serviceResponseDTO);
        }
    }
}
