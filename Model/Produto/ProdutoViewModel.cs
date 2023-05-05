using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Produto
{
    [Table("TB_PRODUTO")]
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        
    }
}
