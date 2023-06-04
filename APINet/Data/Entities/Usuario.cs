using Microsoft.AspNetCore.Identity;

namespace APINet.Data.Entities
{
    public class Usuario : IdentityUser<Guid>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Guid? UsuarioInclusaoId { get; set; }
        public DateTime Inclusao { get; set; }
        public Guid? UsuarioAlteracaoId { get; set; }
        public DateTime? Alteracao { get; set; }

    }
}
