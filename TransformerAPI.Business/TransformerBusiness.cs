using AutoMapper;
using System.Threading.Tasks;
using TransformerAPI.Business.Interfaces;
using TransformerAPI.Data.Interfaces;
using TransformerAPI.Entities;
using TransformerAPI.Shared.DTOs;

namespace TransformerAPI.Business
{
    public class TransformerBusiness : ITransformerBusiness
    {
        private readonly ITransformerRepository _transformerRepository;
        private readonly IMapper _mapper;

        public TransformerBusiness(ITransformerRepository transformerRepository, IMapper mapper)
        {
            _transformerRepository = transformerRepository;
            _mapper = mapper;
        }
        public async Task<TransformerDTO> Create(TransformerDTO transformerDTO)
        {
            Transformer transformer = _mapper.Map<Transformer>(transformerDTO);
            transformer = await _transformerRepository.Create(transformer);
            return _mapper.Map<TransformerDTO>(transformer);
        }

        public async Task<TransformerDTO> Update(TransformerDTO transformerDTO)
        {
            Transformer transformer = _mapper.Map<Transformer>(transformerDTO);
            transformer = await _transformerRepository.Update(transformer);
            return _mapper.Map<TransformerDTO>(transformer);
        }
        public async Task<TransformerDTO> Delete(int id)
        {
            Transformer transformer = await _transformerRepository.Delete(id);
            TransformerDTO transformerDTO = (transformer != null) ? _mapper.Map<TransformerDTO>(transformer) : new TransformerDTO();
            return transformerDTO;
        }
        public async Task<TransformerDTO> Read(int id)
        {
            Transformer transformer = await _transformerRepository.Read(id);
            TransformerDTO transformerDTO = (transformer != null) ? _mapper.Map<TransformerDTO>(transformer) : new TransformerDTO();
            return transformerDTO;
        }
    }
}
