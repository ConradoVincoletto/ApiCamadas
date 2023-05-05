using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Categoria
{
    [Table("TB_CATEGORIA")]
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
    }
}
