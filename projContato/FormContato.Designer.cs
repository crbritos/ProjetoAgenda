namespace projContato {
    partial class FormContato {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.dataGridViewFones = new System.Windows.Forms.DataGridView();
            this.foneNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFones = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxOpcoes = new System.Windows.Forms.GroupBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.groupBoxFones = new System.Windows.Forms.GroupBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonAdicionarFone = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.buttonAbrirLista = new System.Windows.Forms.Button();
            this.groupBoxForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFones)).BeginInit();
            this.groupBoxOpcoes.SuspendLayout();
            this.groupBoxFones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.dataGridViewFones);
            this.groupBoxForm.Controls.Add(this.buttonAdicionar);
            this.groupBoxForm.Controls.Add(this.buttonRemover);
            this.groupBoxForm.Controls.Add(this.textBoxNome);
            this.groupBoxForm.Controls.Add(this.textBoxEmail);
            this.groupBoxForm.Controls.Add(this.labelFones);
            this.groupBoxForm.Controls.Add(this.labelNome);
            this.groupBoxForm.Controls.Add(this.labelEmail);
            this.groupBoxForm.Location = new System.Drawing.Point(7, 5);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(313, 305);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            // 
            // dataGridViewFones
            // 
            this.dataGridViewFones.AllowUserToAddRows = false;
            this.dataGridViewFones.AllowUserToDeleteRows = false;
            this.dataGridViewFones.AllowUserToResizeColumns = false;
            this.dataGridViewFones.AllowUserToResizeRows = false;
            this.dataGridViewFones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFones.ColumnHeadersHeight = 30;
            this.dataGridViewFones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foneNumero,
            this.foneTipo});
            this.dataGridViewFones.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewFones.Location = new System.Drawing.Point(64, 89);
            this.dataGridViewFones.Name = "dataGridViewFones";
            this.dataGridViewFones.ReadOnly = true;
            this.dataGridViewFones.RowHeadersVisible = false;
            this.dataGridViewFones.RowHeadersWidth = 100;
            this.dataGridViewFones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFones.Size = new System.Drawing.Size(203, 140);
            this.dataGridViewFones.TabIndex = 11;
            // 
            // foneNumero
            // 
            this.foneNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foneNumero.HeaderText = "Número";
            this.foneNumero.Name = "foneNumero";
            this.foneNumero.ReadOnly = true;
            // 
            // foneTipo
            // 
            this.foneTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foneTipo.HeaderText = "Tipo";
            this.foneTipo.Name = "foneTipo";
            this.foneTipo.ReadOnly = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(64, 243);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(203, 23);
            this.buttonAdicionar.TabIndex = 10;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(64, 272);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(203, 23);
            this.buttonRemover.TabIndex = 9;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.ButtonRemover_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(64, 63);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(203, 20);
            this.textBoxNome.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(64, 34);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelFones
            // 
            this.labelFones.AutoSize = true;
            this.labelFones.Location = new System.Drawing.Point(21, 92);
            this.labelFones.Name = "labelFones";
            this.labelFones.Size = new System.Drawing.Size(39, 13);
            this.labelFones.TabIndex = 5;
            this.labelFones.Text = "Fones:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(21, 63);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 37);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail:";
            // 
            // groupBoxOpcoes
            // 
            this.groupBoxOpcoes.Controls.Add(this.buttonExcluir);
            this.groupBoxOpcoes.Controls.Add(this.buttonPesquisar);
            this.groupBoxOpcoes.Controls.Add(this.buttonGravar);
            this.groupBoxOpcoes.Controls.Add(this.buttonNovo);
            this.groupBoxOpcoes.Location = new System.Drawing.Point(7, 311);
            this.groupBoxOpcoes.Name = "groupBoxOpcoes";
            this.groupBoxOpcoes.Size = new System.Drawing.Size(313, 71);
            this.groupBoxOpcoes.TabIndex = 1;
            this.groupBoxOpcoes.TabStop = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(236, 23);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(71, 37);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(159, 23);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(71, 37);
            this.buttonPesquisar.TabIndex = 6;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(82, 23);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(71, 37);
            this.buttonGravar.TabIndex = 5;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.ButtonGravar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(5, 23);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(71, 37);
            this.buttonNovo.TabIndex = 4;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // groupBoxFones
            // 
            this.groupBoxFones.Controls.Add(this.comboBoxTipo);
            this.groupBoxFones.Controls.Add(this.textBoxNumero);
            this.groupBoxFones.Controls.Add(this.buttonAdicionarFone);
            this.groupBoxFones.Controls.Add(this.labelTipo);
            this.groupBoxFones.Controls.Add(this.labelNumero);
            this.groupBoxFones.Location = new System.Drawing.Point(335, 136);
            this.groupBoxFones.Name = "groupBoxFones";
            this.groupBoxFones.Size = new System.Drawing.Size(208, 184);
            this.groupBoxFones.TabIndex = 4;
            this.groupBoxFones.TabStop = false;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular"});
            this.comboBoxTipo.Location = new System.Drawing.Point(62, 63);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTipo.TabIndex = 10;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(62, 21);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(127, 20);
            this.textBoxNumero.TabIndex = 9;
            // 
            // buttonAdicionarFone
            // 
            this.buttonAdicionarFone.Location = new System.Drawing.Point(20, 112);
            this.buttonAdicionarFone.Name = "buttonAdicionarFone";
            this.buttonAdicionarFone.Size = new System.Drawing.Size(169, 27);
            this.buttonAdicionarFone.TabIndex = 2;
            this.buttonAdicionarFone.Text = "Adicionar";
            this.buttonAdicionarFone.UseVisualStyleBackColor = true;
            this.buttonAdicionarFone.Click += new System.EventHandler(this.ButtonAdicionarFone_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(17, 66);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 1;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(17, 24);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(22, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Nº:";
            // 
            // buttonAbrirLista
            // 
            this.buttonAbrirLista.Location = new System.Drawing.Point(12, 388);
            this.buttonAbrirLista.Name = "buttonAbrirLista";
            this.buttonAbrirLista.Size = new System.Drawing.Size(302, 37);
            this.buttonAbrirLista.TabIndex = 5;
            this.buttonAbrirLista.Text = "Lista de Contatos";
            this.buttonAbrirLista.UseVisualStyleBackColor = true;
            this.buttonAbrirLista.Visible = false;
            this.buttonAbrirLista.Click += new System.EventHandler(this.ButtonAbrirLista_Click);
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 388);
            this.Controls.Add(this.buttonAbrirLista);
            this.Controls.Add(this.groupBoxFones);
            this.Controls.Add(this.groupBoxOpcoes);
            this.Controls.Add(this.groupBoxForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormContato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contatos";
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFones)).EndInit();
            this.groupBoxOpcoes.ResumeLayout(false);
            this.groupBoxFones.ResumeLayout(false);
            this.groupBoxFones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFones;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxOpcoes;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.DataGridView dataGridViewFones;
        private System.Windows.Forms.GroupBox groupBoxFones;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonAdicionarFone;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneTipo;
        private System.Windows.Forms.Button buttonAbrirLista;
    }
}

