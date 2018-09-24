using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGECOREDOMINIO
{
    [Table("CLI_CLIENTE")]
    public  class Cliente
    {
        public Cliente()
        {
            
        }

        [Key]
        public int Id_Cliente { get; set; }

        [Column(TypeName = "nvarchar(500)"),Required]
        public string Nome_Cliente { get; set; }

        public string Rg_Cliente { get; set; }

        [Column(TypeName = "nvarchar(18)"), Required]
        public string Cpf_Cliente { get; set; }

        [Required]
        public bool E_Func_Cliente { get; set; }

     //   public virtual IList<Ocorrencia> Ocorrencias { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }

        public ICollection<Telefones> Telefones { get; set; }
    }
}
