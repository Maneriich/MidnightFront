namespace Midnight
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxOpcoesP = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbTipoProduto = new System.Windows.Forms.CheckBox();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            this.cbxTipoProduto = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbxOpcoesE = new System.Windows.Forms.ComboBox();
            this.gbxEstabelecimento = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbxDias = new System.Windows.Forms.ListBox();
            this.lblHAbertura = new System.Windows.Forms.Label();
            this.lblHEncerramento = new System.Windows.Forms.Label();
            this.lblNomE = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbxEstabelecimento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cbxOpcoesP);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PRODUTOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tipo,
            this.preco,
            this.descricao});
            this.dataGridView1.Location = new System.Drawing.Point(6, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // cbxOpcoesP
            // 
            this.cbxOpcoesP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOpcoesP.FormattingEnabled = true;
            this.cbxOpcoesP.Items.AddRange(new object[] {
            "ADICIONAR PRODUTO",
            "EDITAR PRODUTOS"});
            this.cbxOpcoesP.Location = new System.Drawing.Point(6, 6);
            this.cbxOpcoesP.Name = "cbxOpcoesP";
            this.cbxOpcoesP.Size = new System.Drawing.Size(212, 26);
            this.cbxOpcoesP.TabIndex = 0;
            this.cbxOpcoesP.SelectedIndexChanged += new System.EventHandler(this.cbxOpcoesP_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 97);
            this.panel1.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(657, 56);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 32);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(657, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 25);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbTipoProduto);
            this.groupBox1.Controls.Add(this.txtTipoProduto);
            this.groupBox1.Controls.Add(this.cbxTipoProduto);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // ckbTipoProduto
            // 
            this.ckbTipoProduto.AutoSize = true;
            this.ckbTipoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTipoProduto.Location = new System.Drawing.Point(6, 60);
            this.ckbTipoProduto.Name = "ckbTipoProduto";
            this.ckbTipoProduto.Size = new System.Drawing.Size(81, 20);
            this.ckbTipoProduto.TabIndex = 2;
            this.ckbTipoProduto.Text = "OUTROS";
            this.ckbTipoProduto.UseVisualStyleBackColor = true;
            this.ckbTipoProduto.CheckedChanged += new System.EventHandler(this.ckbTipoProduto_CheckedChanged);
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProduto.Location = new System.Drawing.Point(6, 21);
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(188, 25);
            this.txtTipoProduto.TabIndex = 1;
            this.txtTipoProduto.Visible = false;
            // 
            // cbxTipoProduto
            // 
            this.cbxTipoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoProduto.FormattingEnabled = true;
            this.cbxTipoProduto.Items.AddRange(new object[] {
            "MESA",
            "INGRESSO",
            "Agua (com gás)",
            "Agua (sem gás)",
            "Caipirinha",
            "Cerveja",
            "Chopp (300ml)",
            "Chopp (500ml)",
            "Chopp (torre)",
            "Chopp de Vinho (300ml)",
            "Chopp de Vinho (500ml)",
            "Chopp de Vinho (torre)",
            "Drink",
            "Dose",
            "Energetico (lata)",
            "Gin Tonica",
            "Gin Tropical",
            "Vinho (taça)",
            "Vinho (garrafa)",
            "Sucos",
            "Refrigerante (lata)",
            "Refrigerante (600ml)",
            "Refrigerante (2L)"});
            this.cbxTipoProduto.Location = new System.Drawing.Point(6, 22);
            this.cbxTipoProduto.Name = "cbxTipoProduto";
            this.cbxTipoProduto.Size = new System.Drawing.Size(188, 24);
            this.cbxTipoProduto.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ATRAÇÕES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ESTOQUE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "VENDA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbxEstabelecimento);
            this.tabPage5.Controls.Add(this.cbxOpcoesE);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ESTABELECIMENTO";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbxOpcoesE
            // 
            this.cbxOpcoesE.FormattingEnabled = true;
            this.cbxOpcoesE.Items.AddRange(new object[] {
            "VISUALIZAR INFORMAÇÕES",
            "EDITAR INFORMAÇÕES"});
            this.cbxOpcoesE.Location = new System.Drawing.Point(8, 8);
            this.cbxOpcoesE.Name = "cbxOpcoesE";
            this.cbxOpcoesE.Size = new System.Drawing.Size(201, 24);
            this.cbxOpcoesE.TabIndex = 1;
            this.cbxOpcoesE.Text = "VISUALIZAR INFORMAÇÕES";
            this.cbxOpcoesE.SelectedIndexChanged += new System.EventHandler(this.cbxOpcoesE_SelectedIndexChanged);
            // 
            // gbxEstabelecimento
            // 
            this.gbxEstabelecimento.Controls.Add(this.lblCNPJ);
            this.gbxEstabelecimento.Controls.Add(this.lblNomE);
            this.gbxEstabelecimento.Controls.Add(this.groupBox2);
            this.gbxEstabelecimento.Controls.Add(this.groupBox3);
            this.gbxEstabelecimento.Controls.Add(this.label11);
            this.gbxEstabelecimento.Controls.Add(this.label12);
            this.gbxEstabelecimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstabelecimento.Location = new System.Drawing.Point(8, 38);
            this.gbxEstabelecimento.Name = "gbxEstabelecimento";
            this.gbxEstabelecimento.Size = new System.Drawing.Size(757, 326);
            this.gbxEstabelecimento.TabIndex = 4;
            this.gbxEstabelecimento.TabStop = false;
            this.gbxEstabelecimento.Text = "Estabelecimento ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHEncerramento);
            this.groupBox2.Controls.Add(this.lblHAbertura);
            this.groupBox2.Controls.Add(this.lbxDias);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(449, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 283);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horario de Funcionamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Horario de Encerramento ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Horaio de Abertura";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBairro);
            this.groupBox3.Controls.Add(this.lblCEP);
            this.groupBox3.Controls.Add(this.lblNumero);
            this.groupBox3.Controls.Add(this.lblRua);
            this.groupBox3.Controls.Add(this.lblEstado);
            this.groupBox3.Controls.Add(this.lblCidade);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(10, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cidade ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "CNPJ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estabelecimento";
            // 
            // lbxDias
            // 
            this.lbxDias.FormattingEnabled = true;
            this.lbxDias.ItemHeight = 16;
            this.lbxDias.Location = new System.Drawing.Point(10, 21);
            this.lbxDias.Name = "lbxDias";
            this.lbxDias.Size = new System.Drawing.Size(169, 116);
            this.lbxDias.TabIndex = 5;
            // 
            // lblHAbertura
            // 
            this.lblHAbertura.AutoSize = true;
            this.lblHAbertura.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHAbertura.Location = new System.Drawing.Point(7, 175);
            this.lblHAbertura.Name = "lblHAbertura";
            this.lblHAbertura.Size = new System.Drawing.Size(87, 17);
            this.lblHAbertura.TabIndex = 6;
            this.lblHAbertura.Text = "lblHAbertura";
            // 
            // lblHEncerramento
            // 
            this.lblHEncerramento.AutoSize = true;
            this.lblHEncerramento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEncerramento.Location = new System.Drawing.Point(7, 230);
            this.lblHEncerramento.Name = "lblHEncerramento";
            this.lblHEncerramento.Size = new System.Drawing.Size(125, 17);
            this.lblHEncerramento.TabIndex = 7;
            this.lblHEncerramento.Text = "lblHEncerramento";
            // 
            // lblNomE
            // 
            this.lblNomE.AutoSize = true;
            this.lblNomE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomE.Location = new System.Drawing.Point(7, 54);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(63, 17);
            this.lblNomE.TabIndex = 6;
            this.lblNomE.Text = "lblNomE";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(7, 106);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(60, 17);
            this.lblCNPJ.TabIndex = 7;
            this.lblCNPJ.Text = "lblCNPJ";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(7, 45);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(68, 17);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "lblCidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(242, 44);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 18);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "lblEstado";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(7, 96);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(49, 17);
            this.lblRua.TabIndex = 14;
            this.lblRua.Text = "lblRua";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(242, 96);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(74, 17);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "lblNumero";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(242, 148);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(53, 17);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "lblCEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(7, 148);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(61, 17);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "lblBairro";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDNIGHT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.gbxEstabelecimento.ResumeLayout(false);
            this.gbxEstabelecimento.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxOpcoesP;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbTipoProduto;
        private System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.ComboBox cbxTipoProduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOpcoesE;
        private System.Windows.Forms.GroupBox gbxEstabelecimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbxDias;
        private System.Windows.Forms.Label lblHEncerramento;
        private System.Windows.Forms.Label lblHAbertura;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
    }
}

