using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Estoque;
using Produtos;


namespace WindowsFormsApp2
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            estProduto _estProduto = new estProduto();
            _estProduto.Exclui(Convert.ToInt32(txtCodProd.Text));
        }
    }
}
