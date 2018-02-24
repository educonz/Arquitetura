using Core.Domain;

namespace Dominio
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
    }
}
