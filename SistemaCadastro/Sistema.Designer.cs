namespace SistemaCadastro
{
    partial class Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.bntAddDono = new System.Windows.Forms.Button();
            this.cbDono = new System.Windows.Forms.ComboBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtTempoMedioAtivo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveEletrodomestico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgEletrodomesticos = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.cbAlteraDono = new System.Windows.Forms.ComboBox();
            this.txtAlteraPotencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlteraTempoMedioAtivo = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEletrodomesticos)).BeginInit();
            this.tabAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 435);
            this.panel1.TabIndex = 0;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.Yellow;
            this.marcador.Location = new System.Drawing.Point(1, 85);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(10, 36);
            this.marcador.TabIndex = 8;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(16, 128);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(131, 49);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "&Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.FlatAppearance.BorderSize = 0;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.Location = new System.Drawing.Point(16, 81);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(131, 49);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "&Cadastrar";
            this.btnCadastra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 23);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(45, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 131);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(161, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 52);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eletrodomésticos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(155, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 278);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.bntAddDono);
            this.tabCadastrar.Controls.Add(this.cbDono);
            this.tabCadastrar.Controls.Add(this.txtPotencia);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtTempoMedioAtivo);
            this.tabCadastrar.Controls.Add(this.txtnome);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 25);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(664, 249);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // bntAddDono
            // 
            this.bntAddDono.FlatAppearance.BorderSize = 0;
            this.bntAddDono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bntAddDono.ForeColor = System.Drawing.Color.DimGray;
            this.bntAddDono.Image = global::SistemaCadastro.Properties.Resources.botao_adicionar__1_;
            this.bntAddDono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddDono.Location = new System.Drawing.Point(616, 50);
            this.bntAddDono.Name = "bntAddDono";
            this.bntAddDono.Size = new System.Drawing.Size(43, 35);
            this.bntAddDono.TabIndex = 15;
            this.bntAddDono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddDono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAddDono.UseVisualStyleBackColor = true;
            this.bntAddDono.Click += new System.EventHandler(this.bntAddDono_Click);
            // 
            // cbDono
            // 
            this.cbDono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDono.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbDono.FormattingEnabled = true;
            this.cbDono.Location = new System.Drawing.Point(132, 53);
            this.cbDono.Margin = new System.Windows.Forms.Padding(2);
            this.cbDono.Name = "cbDono";
            this.cbDono.Size = new System.Drawing.Size(480, 29);
            this.cbDono.TabIndex = 10;
            this.cbDono.SelectedIndexChanged += new System.EventHandler(this.cbDono_SelectedIndexChanged);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPotencia.Location = new System.Drawing.Point(132, 131);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(480, 26);
            this.txtPotencia.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Potência (kW):";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(285, 173);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(131, 49);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtTempoMedioAtivo
            // 
            this.txtTempoMedioAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTempoMedioAtivo.Location = new System.Drawing.Point(132, 91);
            this.txtTempoMedioAtivo.Name = "txtTempoMedioAtivo";
            this.txtTempoMedioAtivo.Size = new System.Drawing.Size(480, 26);
            this.txtTempoMedioAtivo.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnome.Location = new System.Drawing.Point(132, 9);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(480, 29);
            this.txtnome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo (h/dia):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.White;
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnRemoveEletrodomestico);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtBusca);
            this.tabBuscar.Controls.Add(this.dgEletrodomesticos);
            this.tabBuscar.Location = new System.Drawing.Point(4, 25);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(664, 249);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(482, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 46);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemoveEletrodomestico
            // 
            this.btnRemoveEletrodomestico.FlatAppearance.BorderSize = 0;
            this.btnRemoveEletrodomestico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEletrodomestico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveEletrodomestico.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveEletrodomestico.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveEletrodomestico.Image")));
            this.btnRemoveEletrodomestico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEletrodomestico.Location = new System.Drawing.Point(363, 5);
            this.btnRemoveEletrodomestico.Name = "btnRemoveEletrodomestico";
            this.btnRemoveEletrodomestico.Size = new System.Drawing.Size(122, 46);
            this.btnRemoveEletrodomestico.TabIndex = 14;
            this.btnRemoveEletrodomestico.Text = "Remover";
            this.btnRemoveEletrodomestico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEletrodomestico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveEletrodomestico.UseVisualStyleBackColor = true;
            this.btnRemoveEletrodomestico.Click += new System.EventHandler(this.btnRemoveEletrodomestico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Eletro:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBusca.Location = new System.Drawing.Point(82, 10);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(261, 26);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgEletrodomesticos
            // 
            this.dgEletrodomesticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEletrodomesticos.BackgroundColor = System.Drawing.Color.White;
            this.dgEletrodomesticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEletrodomesticos.Location = new System.Drawing.Point(42, 55);
            this.dgEletrodomesticos.Margin = new System.Windows.Forms.Padding(2);
            this.dgEletrodomesticos.Name = "dgEletrodomesticos";
            this.dgEletrodomesticos.ReadOnly = true;
            this.dgEletrodomesticos.RowHeadersWidth = 51;
            this.dgEletrodomesticos.RowTemplate.Height = 29;
            this.dgEletrodomesticos.Size = new System.Drawing.Size(598, 189);
            this.dgEletrodomesticos.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.cbAlteraDono);
            this.tabAlterar.Controls.Add(this.txtAlteraPotencia);
            this.tabAlterar.Controls.Add(this.label7);
            this.tabAlterar.Controls.Add(this.txtAlteraTempoMedioAtivo);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Location = new System.Drawing.Point(4, 25);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlterar.Size = new System.Drawing.Size(664, 249);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.UseVisualStyleBackColor = true;
            // 
            // cbAlteraDono
            // 
            this.cbAlteraDono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlteraDono.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAlteraDono.FormattingEnabled = true;
            this.cbAlteraDono.Location = new System.Drawing.Point(128, 61);
            this.cbAlteraDono.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlteraDono.Name = "cbAlteraDono";
            this.cbAlteraDono.Size = new System.Drawing.Size(480, 29);
            this.cbAlteraDono.TabIndex = 23;
            // 
            // txtAlteraPotencia
            // 
            this.txtAlteraPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAlteraPotencia.Location = new System.Drawing.Point(128, 144);
            this.txtAlteraPotencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlteraPotencia.Name = "txtAlteraPotencia";
            this.txtAlteraPotencia.Size = new System.Drawing.Size(480, 26);
            this.txtAlteraPotencia.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(8, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Potência (kW):";
            // 
            // txtAlteraTempoMedioAtivo
            // 
            this.txtAlteraTempoMedioAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAlteraTempoMedioAtivo.Location = new System.Drawing.Point(128, 104);
            this.txtAlteraTempoMedioAtivo.Name = "txtAlteraTempoMedioAtivo";
            this.txtAlteraTempoMedioAtivo.Size = new System.Drawing.Size(480, 26);
            this.txtAlteraTempoMedioAtivo.TabIndex = 19;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlteraNome.Location = new System.Drawing.Point(128, 22);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(480, 29);
            this.txtAlteraNome.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(8, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tempo (h/dia):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(8, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(8, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome:";
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(292, 176);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(131, 49);
            this.btnConfirmaAlteracao.TabIndex = 22;
            this.btnConfirmaAlteracao.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(544, 26);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(800, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 435);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEletrodomesticos)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtTempoMedioAtivo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgEletrodomesticos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnRemoveEletrodomestico;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.TextBox txtAlteraPotencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.TextBox txtAlteraTempoMedioAtivo;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDono;
        private System.Windows.Forms.Button bntAddDono;
        private System.Windows.Forms.ComboBox cbAlteraDono;
    }
}