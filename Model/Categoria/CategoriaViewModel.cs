using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model.Categoria
{
    [Table("TB_CATEGORIA")]
    public class CategoriaViewModel
    {
        [Column("CTG_ID")]
        [Display(Name = "Código_CTG")]
        public int Id { get; set; }

        [Column("CTG_NOME")]
        [Display(Name = "Nome_Categoria")]
        [MaxLength(200)]
        public string NomeCategoria { get; set; }
    }
}
