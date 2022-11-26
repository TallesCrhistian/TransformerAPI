using AutoMapper;
using System.Threading.Tasks;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business
{
    public class TestBusiness : ITestBusiness
    {
        private readonly ITestRepository _testRepository;
        private readonly IMapper _mapper;

        public TestBusiness(ITestRepository testRepository, IMapper mapper)
        {
            _testRepository = testRepository;
            _mapper = mapper;
        }

        public async Task<TestDTO> Create(TestDTO testDTO)
        {
            Test test = _mapper.Map<Test>(testDTO);
            test = await _testRepository.Create(test);
            return _mapper.Map<TestDTO>(test);
        }

        public async Task<TestDTO> Update(TestDTO testDTO, string id)
        {
            Test test = _mapper.Map<Test>(testDTO);
            test.Id = id;
            test = await _testRepository.Update(test, id);
            return _mapper.Map<TestDTO>(test);
        }

        public async Task<TestDTO> Delete(string id)
        {
            Test test = await _testRepository.Delete(id);
            TestDTO testDTO = (test != null) ? _mapper.Map<TestDTO>(test) : new TestDTO();
            return testDTO;
        }

        public async Task<TestDTO> Read(string id)
        {
            Test test = await _testRepository.Read(id);
            TestDTO testDTO = (test != null) ? _mapper.Map<TestDTO>(test) : new TestDTO();
            return testDTO;
        }
    }
}
