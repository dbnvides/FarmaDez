using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Produtos;
using Controle_Estoque;


namespace WindowsFormsApp2
{
    public partial class AlterarProduto : Form
    {
        public AlterarProduto()
        {
            InitializeComponent();
        }

        //BOTAO QUE ABRE A JANELA PARA ALTERAR OS DADOS DO PRODUTO
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto _produto = new Produto();
            _produto.cod_prod = Convert.ToInt32(txtCodProd.Text);
            _produto.nome_prod = txtNome.Text;
            _produto.desc_prod = txtDescProdAB.Text;
            _produto.desc_completa_prod = txtDescProd.Text;
            _produto.qtd_prod = Convert.ToInt32(qntd_Prod.Text);
            _produto.tipo_prod = comboBox1.Text;
            _produto.validade_prod = mask_Val.Text;
            _produto.msaude_prod = txtCodigoM.Text;
            _produto.fabrica_prod = mask_Fabrica.Text;

            estProduto _estProduto = new estProduto();
            _estProduto.Alterar(_produto.cod_prod,_produto.nome_prod,_produto.desc_prod,_produto.desc_completa_prod,_produto.qtd_prod,_produto.fabrica_prod,_produto.validade_prod,_produto.tipo_prod,_produto.msaude_prod);
            btnLimpar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodProd.Text = "";
            txtNome.Text = "";
            txtDescProdAB.Text = "";
            txtDescProd.Text = "";
            qntd_Prod.Text = "";
            txtCodigoM.Text = "";
            chkSim.Checked = false;
            chkNao.Checked = false;
            mask_Fabrica.Text = "";
            mask_Val.Text = "";
            dvg_DadosProd.DataSource = null;
            dvg_DadosProd.Refresh();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Interface intf = new Interface();
            intf.Show();
        }

        private void chkSim_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoM.Enabled = true;
        }

        private void chkNao_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoM.Enabled = false;
        }
        private void Consulta_Load(object sender, EventArgs e)
        {
            txtCodigoM.Enabled = false;
            if (chkSim.Checked)
            {
                txtCodigoM.Enabled = true;
            }

        }

        private void mask_Fabrica_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Produto _produto = new Produto();
            _produto.cod_prod = Convert.ToInt32(txtCodProd.Text);
            estProduto _estProduto = new estProduto();
            DataTable dtbProduto = new DataTable();
            dtbProduto = _estProduto.Busca(_produto.cod_prod);
            dvg_DadosProd.DataSource = dtbProduto;
            
        }

        private void dvg_DadosProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvg_DadosProd.CurrentRow.Index != -1)
            {
                txtCodProd.Text = dvg_DadosProd.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dvg_DadosProd.CurrentRow.Cells[1].Value.ToString();
                txtDescProdAB.Text = dvg_DadosProd.CurrentRow.Cells[2].Value.ToString();
                txtDescProd.Text = dvg_DadosProd.CurrentRow.Cells[3].Value.ToString();
                qntd_Prod.Text = dvg_DadosProd.CurrentRow.Cells[4].Value.ToString();
                comboBox1.Text = dvg_DadosProd.CurrentRow.Cells[5].Value.ToString();
                mask_Val.Text = dvg_DadosProd.CurrentRow.Cells[6].Value.ToString();
                txtCodigoM.Text = dvg_DadosProd.CurrentRow.Cells[7].Value.ToString();
                mask_Fabrica.Text = dvg_DadosProd.CurrentRow.Cells[8].Value.ToString();

                btnLimpar.Enabled = false;
            }
        }

        private void Cad_Produto_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
