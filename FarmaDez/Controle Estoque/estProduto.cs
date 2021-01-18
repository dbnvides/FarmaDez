using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Produtos;
using System.Windows.Forms;

namespace Controle_Estoque
{
    public class estProduto
    {
        public bool CadastroProduto(int cod_prod, string nome_prod, string desc_prod, string desc_completa_prod, int qtd_prod, string tipo_prod, string fabricacao_prod, string msaude_prod, string validade_prod)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            
            //ALTERAR PARA CONECTAR!

            SqlConn.ConnectionString = @"Data Source = DIONISIO; Initial Catalog = DBFarmaDez; Integrated Security = True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("sp_insertProduto", SqlConn);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlCmd.Parameters.AddWithValue("@SP_codigo_produto", cod_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_nome_produto", nome_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_descricao_abreviada", desc_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_descricao_completa", desc_completa_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_quantidade", qtd_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_tipo", tipo_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_validade", validade_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_msaude", msaude_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_fabricacao", fabricacao_prod);



                    SqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Salvo com sucesso!! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O registro não pode ser salvo !! " + ex.Message);
                throw ex;
            }

            return true;
        }

        


        //public void Lista()
        public DataTable Lista()
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();

            //ALTERAR PARA CONECTAR!.
            SqlConn.ConnectionString = @"Data Source = DIONISIO; Initial Catalog = DBFarmaDez; Integrated Security = True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("Select * from produto", SqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbProduto = new DataTable();
                    adapter.Fill(dtbProduto);
                    return dtbProduto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        

        public DataTable Busca(int cod_prod)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();

            //ALTERAR PARA CONECTAR!.
            SqlConn.ConnectionString = @"Data Source = DIONISIO; Initial Catalog = DBFarmaDez; Integrated Security = True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("Select * from produto where Codigo = @SP_codigo_produto", SqlConn);
                    SqlCmd.Parameters.AddWithValue("@SP_codigo_produto", cod_prod);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbProduto = new DataTable();
                    adapter.Fill(dtbProduto);
                    return dtbProduto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        public void Exclui(int cod_prod)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            
            //ALTERAR PARA CONECTAR!.
            SqlConn.ConnectionString = @"Data Source = DIONISIO; Initial Catalog = DBFarmaDez; Integrated Security = True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("Delete from produto where Codigo = @codigo_produto", SqlConn);
                    SqlCmd.Parameters.AddWithValue("@codigo_produto", cod_prod);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbProduto = new DataTable();
                    adapter.Fill(dtbProduto);
                    SqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Excluído com sucesso");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //ESSE METODO ALTERA AS INFORMAÇÕES
        public void Alterar(int cod_prod, string nome_prod, string desc_prod, string desc_completa_prod, int qtd_prod, string fabricacao_prod, string validade_prod, string tipo_prod, string msaude_prod)
        {
            //Define uma string de conexão com o banco de dados
            SqlConnection SqlConn = new SqlConnection();
            //ALTERAR PARA CONECTAR!.
            SqlConn.ConnectionString = @"Data Source = DIONISIO; Initial Catalog = DBFarmaDez; Integrated Security = True";

            try
            {
                //Abre a conxexão
                SqlConn.Open();
                {
                    SqlCommand SqlCmd = new SqlCommand("Update produto Set Codigo=@SP_codigo_produto, Nome=@SP_nome_produto, DescAbreviada=@SP_descricao_abreviada, DescCompleta=@SP_descricao_completa, Quantidade=@SP_quantidade, Tipo=@SP_tipo, Fabricação=@SP_fabricacao, MSaude=@SP_msaude, Validade=@SP_validade ", SqlConn);
                    SqlCmd.Parameters.AddWithValue("@SP_codigo_produto", cod_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_nome_produto", nome_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_descricao_abreviada", desc_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_descricao_completa", desc_completa_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_quantidade", qtd_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_fabricacao", fabricacao_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_validade", validade_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_msaude", msaude_prod);
                    SqlCmd.Parameters.AddWithValue("@SP_tipo", tipo_prod);
                    SqlCmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = SqlCmd;
                    DataTable dtbProduto = new DataTable();
                    adapter.Fill(dtbProduto);
                    
                    MessageBox.Show("Alterado com sucesso");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
}
