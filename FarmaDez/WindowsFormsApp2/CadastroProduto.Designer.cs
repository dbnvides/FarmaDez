namespace WindowsFormsApp2
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cad_Produto = new System.Windows.Forms.TabPage();
            this.chkNao = new System.Windows.Forms.CheckBox();
            this.chkSim = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dvg_DadosProd = new System.Windows.Forms.DataGridView();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescProdAB = new System.Windows.Forms.TextBox();
            this.mask_Val = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mask_Fabrica = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qntd_Prod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cad_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DadosProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntd_Prod)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cad_Produto
            // 
            this.Cad_Produto.BackColor = System.Drawing.Color.Gainsboro;
            this.Cad_Produto.Controls.Add(this.chkNao);
            this.Cad_Produto.Controls.Add(this.chkSim);
            this.Cad_Produto.Controls.Add(this.label10);
            this.Cad_Produto.Controls.Add(this.txtCodigoM);
            this.Cad_Produto.Controls.Add(this.label9);
            this.Cad_Produto.Controls.Add(this.btnVoltar);
            this.Cad_Produto.Controls.Add(this.comboBox1);
            this.Cad_Produto.Controls.Add(this.btnConsultar);
            this.Cad_Produto.Controls.Add(this.btnLimpar);
            this.Cad_Produto.Controls.Add(this.btnSalvar);
            this.Cad_Produto.Controls.Add(this.dvg_DadosProd);
            this.Cad_Produto.Controls.Add(this.txtDescProd);
            this.Cad_Produto.Controls.Add(this.txtNome);
            this.Cad_Produto.Controls.Add(this.txtDescProdAB);
            this.Cad_Produto.Controls.Add(this.mask_Val);
            this.Cad_Produto.Controls.Add(this.label8);
            this.Cad_Produto.Controls.Add(this.mask_Fabrica);
            this.Cad_Produto.Controls.Add(this.label7);
            this.Cad_Produto.Controls.Add(this.label6);
            this.Cad_Produto.Controls.Add(this.label5);
            this.Cad_Produto.Controls.Add(this.label4);
            this.Cad_Produto.Controls.Add(this.qntd_Prod);
            this.Cad_Produto.Controls.Add(this.label3);
            this.Cad_Produto.Controls.Add(this.label2);
            this.Cad_Produto.Controls.Add(this.txtCodProd);
            this.Cad_Produto.Controls.Add(this.label1);
            this.Cad_Produto.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cad_Produto.Location = new System.Drawing.Point(4, 27);
            this.Cad_Produto.Name = "Cad_Produto";
            this.Cad_Produto.Padding = new System.Windows.Forms.Padding(3);
            this.Cad_Produto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cad_Produto.Size = new System.Drawing.Size(709, 572);
            this.Cad_Produto.TabIndex = 0;
            this.Cad_Produto.Text = "Cadastro de Produto";
            this.Cad_Produto.Click += new System.EventHandler(this.Cad_Produto_Click);
            // 
            // chkNao
            // 
            this.chkNao.AutoSize = true;
            this.chkNao.Location = new System.Drawing.Point(85, 171);
            this.chkNao.Name = "chkNao";
            this.chkNao.Size = new System.Drawing.Size(57, 23);
            this.chkNao.TabIndex = 30;
            this.chkNao.Text = "Não";
            this.chkNao.UseVisualStyleBackColor = true;
            this.chkNao.CheckedChanged += new System.EventHandler(this.chkNao_CheckedChanged);
            // 
            // chkSim
            // 
            this.chkSim.AutoSize = true;
            this.chkSim.Location = new System.Drawing.Point(14, 171);
            this.chkSim.Name = "chkSim";
            this.chkSim.Size = new System.Drawing.Size(54, 23);
            this.chkSim.TabIndex = 29;
            this.chkSim.Text = "Sim";
            this.chkSim.UseVisualStyleBackColor = true;
            this.chkSim.CheckedChanged += new System.EventHandler(this.chkSim_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Controlado";
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.Location = new System.Drawing.Point(220, 166);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.Size = new System.Drawing.Size(197, 27);
            this.txtCodigoM.TabIndex = 27;
            this.txtCodigoM.TextChanged += new System.EventHandler(this.txtCodigoM_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Código Ministério da saúde";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(14, 289);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 33);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Perfumaria\t",
            "Medicamento",
            "Bonificado"});
            this.comboBox1.Location = new System.Drawing.Point(65, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(286, 289);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 33);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Visualizar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(523, 289);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(628, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 33);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dvg_DadosProd
            // 
            this.dvg_DadosProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_DadosProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_DadosProd.Location = new System.Drawing.Point(6, 328);
            this.dvg_DadosProd.Name = "dvg_DadosProd";
            this.dvg_DadosProd.Size = new System.Drawing.Size(697, 238);
            this.dvg_DadosProd.TabIndex = 20;
            this.dvg_DadosProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_DadosProd_CellContentClick);
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(14, 93);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(512, 27);
            this.txtDescProd.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(393, 27);
            this.txtNome.TabIndex = 10;
            // 
            // txtDescProdAB
            // 
            this.txtDescProdAB.Location = new System.Drawing.Point(549, 26);
            this.txtDescProdAB.Name = "txtDescProdAB";
            this.txtDescProdAB.Size = new System.Drawing.Size(155, 27);
            this.txtDescProdAB.TabIndex = 3;
            // 
            // mask_Val
            // 
            this.mask_Val.Location = new System.Drawing.Point(583, 218);
            this.mask_Val.Mask = "00/00/0000";
            this.mask_Val.Name = "mask_Val";
            this.mask_Val.Size = new System.Drawing.Size(104, 27);
            this.mask_Val.TabIndex = 17;
            this.mask_Val.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Validade:";
            // 
            // mask_Fabrica
            // 
            this.mask_Fabrica.Location = new System.Drawing.Point(352, 218);
            this.mask_Fabrica.Mask = "00/00/0000";
            this.mask_Fabrica.Name = "mask_Fabrica";
            this.mask_Fabrica.Size = new System.Drawing.Size(103, 27);
            this.mask_Fabrica.TabIndex = 15;
            this.mask_Fabrica.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fabricação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descrição Completa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo:";
            // 
            // qntd_Prod
            // 
            this.qntd_Prod.Location = new System.Drawing.Point(583, 94);
            this.qntd_Prod.Name = "qntd_Prod";
            this.qntd_Prod.Size = new System.Drawing.Size(120, 27);
            this.qntd_Prod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição abreviada:";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(14, 26);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(100, 27);
            this.txtCodProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cad_Produto);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 603);
            this.tabControl1.TabIndex = 0;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 616);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarmaDez";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.Cad_Produto.ResumeLayout(false);
            this.Cad_Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_DadosProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntd_Prod)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Cad_Produto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dvg_DadosProd;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescProdAB;
        private System.Windows.Forms.MaskedTextBox mask_Val;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mask_Fabrica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown qntd_Prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCodProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkNao;
        private System.Windows.Forms.CheckBox chkSim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVoltar;
    }
}

