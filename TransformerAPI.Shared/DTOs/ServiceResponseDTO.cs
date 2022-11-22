using TransformerAPI.Shared.Posts;

namespace TransformerAPI.Shared.DTOs
{
    public class ServiceResponseDTO<T>
    {
        public T Dados { get; set; }
        public bool Sucesso { get; set; } = true;
        public string Mensagem { get; set; } = ConstantMessages.OperationCompletedWithSuccess;
    }
}
