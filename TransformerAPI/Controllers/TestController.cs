using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransformerAPI.Application.Interfaces;
using TransformerAPI.Shared.DTOs;
using TransformerAPI.Shared.ViewModel.TestViewModel;

namespace TransformerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestServices _testServices;
        private readonly IMapper _mapper;

        public TestController(ITestServices testServices, IMapper mapper)
        {
            _testServices = testServices;
            _mapper = mapper;
        }
        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] TestViewModelCreate testViewModelCreate)
        {
            TestDTO testDTO = _mapper.Map<TestDTO>(testViewModelCreate);
            ServiceResponseDTO<TestDTO> serviceResponseDTO = await _testServices.Create(testDTO);
            return Ok(serviceResponseDTO);
        }
        [HttpPut]
        [Route(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] TestViewModelUpdate testViewModelUpdate)
        {
            TestDTO testDTO = _mapper.Map<TestDTO>(testViewModelUpdate);
            ServiceResponseDTO<TestDTO> ServiceResponseDTO = await _testServices.Update(testDTO);
            return Ok(ServiceResponseDTO);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponseDTO<TestDTO> serviceResponseDTO = await _testServices.Delete(id);
            return Ok(serviceResponseDTO);
        }
        [HttpPost("{id:int}")]
        public async Task<IActionResult> ObterPorCodigo(int id)
        {
            ServiceResponseDTO<TestDTO> serviceResponseDTO = await _testServices.Read(id);
            return Ok(serviceResponseDTO);
        }
    }
}
