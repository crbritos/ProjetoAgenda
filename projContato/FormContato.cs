using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projContato {
    public partial class FormContato : Form {

        Contato contato;
        Contatos lista;
        FormLista frmLista;

        public DataGridView dataGridViewFones2;

        public FormContato() {
            InitializeComponent();

            contato = new Contato();
            lista = new Contatos();

            this.Size = new System.Drawing.Size(344, 427);
            comboBoxTipo.SelectedIndex = 0;
        }
        private void ButtonNovo_Click(object sender, EventArgs e) {
            LimparForm(1);
        }
            
        private void ButtonAdicionar_Click(object sender, EventArgs e) {
            this.Size = new System.Drawing.Size(572, 427);
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e) {

            if(lista.MeusContatos.Contains(new Contato(textBoxEmail.Text))) {
                contato = lista.pesquisar(new Contato(textBoxEmail.Text));
         
                LimparForm(1);

                textBoxEmail.Text = contato.Email;
                textBoxNome.Text = contato.Nome;
                for (int i = 0; i < contato.Fones.Count; i++) {
                    dataGridViewFones.Rows.Add(contato.Fones[i].Numero, contato.Fones[i].Tipo);
                }
            } else {
                MsgBox("Erro", "Contato não encontrado");
            }
   
        }

        private void ButtonAdicionarFone_Click(object sender, EventArgs e)
        {
            if(textBoxNumero.Text.Equals("")) {
                MsgBox("Atenção", "Campo número vazio");
            } else {
                dataGridViewFones.Rows.Add(textBoxNumero.Text, comboBoxTipo.SelectedItem);
                contato.adicionarFone(new Fone(textBoxNumero.Text, comboBoxTipo.Text));
                this.Size = new System.Drawing.Size(344, 427);
                LimparForm(2);
            }
            
        }

        private void ButtonGravar_Click(object sender, EventArgs e) {
            contato.Email = textBoxEmail.Text;
            contato.Nome = textBoxNome.Text;

            if (textBoxEmail.Text.Equals("") || textBoxNome.Text.Equals("") || dataGridViewFones.Rows.Count == 0) {
                MsgBox("Atenção", "Preencha todos os campos");
            } else {
                if (lista.MeusContatos.Contains(new Contato(textBoxEmail.Text))) {
                    lista.alterar(contato);
                    MsgBox("Sucesso", "Contato alterado com sucesso");
                } else {
                    lista.adicionar(contato);
                    MsgBox("Sucesso", "Contato criado com sucesso");
                }

                LimparForm(1);
            }

                

        }

        private void ButtonExcluir_Click(object sender, EventArgs e) {
            if(lista.remover(new Contato(textBoxEmail.Text))) {
                MsgBox("Sucesso", "Contato removido");
                LimparForm(1);
            } else {
                MsgBox("Erro", "Contato não encontrado");
            }
        }
        private void LimparForm(int op) {
            if (op == 1) {
                textBoxEmail.Text = "";
                textBoxNome.Text = "";
                dataGridViewFones.Rows.Clear();
                textBoxNumero.Text = "";
                comboBoxTipo.SelectedIndex = 0;
            } else {
                textBoxNumero.Text = "";
                comboBoxTipo.SelectedIndex = 0;
            }
            
        }

        private void ButtonRemover_Click(object sender, EventArgs e) {
            if (dataGridViewFones.Rows.Count >= 1) {
                if (dataGridViewFones.Rows[dataGridViewFones.CurrentRow.Index].IsNewRow != true) {
                    dataGridViewFones.Rows.Remove(dataGridViewFones.CurrentRow);
                }
            } else {
                MsgBox("Erro", "Selecione um telefone");
            }
        }

        private void MsgBox(string opcao, string texto) {
            if (opcao.Equals("Sucesso")) {
                MessageBox.Show(texto, opcao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (opcao.Equals("Atenção")) {
                MessageBox.Show(texto, opcao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            } else if (opcao.Equals("Erro")) {
                MessageBox.Show(texto, opcao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAbrirLista_Click(object sender, EventArgs e) {
            frmLista = new FormLista(lista);
            frmLista.Show();
        }
    }
}
