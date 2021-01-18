using Controle_Estoque;
using Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Interface : Form
    {

        
        public Interface()
        {
            InitializeComponent();

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            CadastroProduto cons = new CadastroProduto();
            cons.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            if (txtBuscarCod != null)
            {
                Produto _produto = new Produto();
                _produto.cod_prod = Convert.ToInt32(txtBuscarCod.Text);

                estProduto _estProduto = new estProduto();
                DataTable dtbProduto = new DataTable();
                dtbProduto = _estProduto.Busca(_produto.cod_prod);

                dvg_Consulta.DataSource = dtbProduto;
            }
            else if (txtBuscarProd != null)
            {
                Produto _produto = new Produto();
                _produto.nome_prod = txtBuscarProd.Text;

                estProduto _estProduto = new estProduto();
                DataTable dtbProduto = new DataTable();
                dtbProduto = _estProduto.Busca(_produto.cod_prod);
                dvg_Consulta.DataSource = dtbProduto;

            }
 
        }

        private void dvg_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto _produto = new Produto();
            estProduto _estProduto = new estProduto();
            DataTable dtbProduto = new DataTable();
            dvg_Consulta.DataSource = dtbProduto;
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            AlterarProduto alt = new AlterarProduto();
            alt.Show();

        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            Excluir ex = new Excluir();
            ex.Show();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            estProduto _estProduto = new estProduto();
            DataTable dtbCliente = new DataTable();
            dtbCliente = _estProduto.Lista();

            dvg_Consulta.DataSource = dtbCliente;
        }
    }
}
