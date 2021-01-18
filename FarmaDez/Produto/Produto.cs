using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    public class Produto
    {
        public int cod_prod { get; set; }
        public String nome_prod { get; set; }
        public String desc_prod { get; set; }
        public String desc_completa_prod { get; set; }
        public int qtd_prod { get; set; }
        public String tipo_prod  { get; set; }
        public String msaude_prod { get; set; }
        public String fabrica_prod { get; set; }
        public String validade_prod { get; set; }

    }
}
