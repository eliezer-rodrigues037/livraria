namespace livraria.api.Models
{
    public class ValidaCadastroViewModelOutput
    {
        public IEnumerable<string> Erros { get; private set; }

        public ValidaCadastroViewModelOutput(IEnumerable<String> erros)
        {
            Erros = erros;
        }

    }
}
