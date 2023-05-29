using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEstucoCompra.Entidade.Entidade
{
    [Table("Login")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoginId { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}
