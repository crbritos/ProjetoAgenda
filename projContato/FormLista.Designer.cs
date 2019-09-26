namespace projContato {
    partial class FormLista {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            this.contatoEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoFones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.AllowUserToAddRows = false;
            this.dataGridViewContatos.AllowUserToDeleteRows = false;
            this.dataGridViewContatos.AllowUserToResizeColumns = false;
            this.dataGridViewContatos.AllowUserToResizeRows = false;
            this.dataGridViewContatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContatos.ColumnHeadersHeight = 30;
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contatoEmail,
            this.contatoNome,
            this.contatoFones});
            this.dataGridViewContatos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewContatos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            this.dataGridViewContatos.ReadOnly = true;
            this.dataGridViewContatos.RowHeadersVisible = false;
            this.dataGridViewContatos.RowHeadersWidth = 100;
            this.dataGridViewContatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewContatos.Size = new System.Drawing.Size(675, 574);
            this.dataGridViewContatos.TabIndex = 12;
            // 
            // contatoEmail
            // 
            this.contatoEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contatoEmail.HeaderText = "E-mail";
            this.contatoEmail.Name = "contatoEmail";
            this.contatoEmail.ReadOnly = true;
            // 
            // contatoNome
            // 
            this.contatoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contatoNome.HeaderText = "Nome";
            this.contatoNome.Name = "contatoNome";
            this.contatoNome.ReadOnly = true;
            // 
            // contatoFones
            // 
            this.contatoFones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contatoFones.HeaderText = "Fones";
            this.contatoFones.Name = "contatoFones";
            this.contatoFones.ReadOnly = true;
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 574);
            this.Controls.Add(this.dataGridViewContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLista";
            this.Text = "Lista de Contatos";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoFones;
    }
}