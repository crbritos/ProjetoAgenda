using projFilaAtendimento.controller;
using projFilaAtendimento.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projFilaAtendimento {
    public partial class FormAtendimento : Form {

        private Guiches listaGuiches;
        private Guiche guiche;
        private int numGuiche;
        private int numChamaGuiche;

        private Senhas listaSenhas;

        public FormAtendimento() {
            InitializeComponent();
            numGuiche = 0;
            listaSenhas = new Senhas();
            listaGuiches = new Guiches();
            guiche = new Guiche();
        }

        private void ButtonGerar_Click(object sender, EventArgs e) {
            // Gerar Senha
            listaSenhas.gerar();
        }

        private void ButtonListarSenhas_Click(object sender, EventArgs e) {
            // Listar Senhas
            listBoxSenhas.Items.Clear();

            if (listaSenhas.FilaSenhas.Count >= 1) {
                listBoxSenhas.Items.Add("--------------------------------------------------------------");
                listBoxSenhas.Items.Add("  Senha\t| \tGerado");
                listBoxSenhas.Items.Add("--------------------------------------------------------------");
                foreach (Senha s in listaSenhas.FilaSenhas) {
                    listBoxSenhas.Items.Add(s.dadosParciais());
                }
            } else listBoxSenhas.Items.Add("Lista de Senhas Vazia");
        }

        private void ButtonAdicionarGuiche_Click(object sender, EventArgs e) {
            // Adicionar Guichê
            numGuiche = numGuiche + 1;
            listaGuiches.adicionar(new Guiche(numGuiche));
            
            labelQuantidadeGuiches.Text = numGuiche.ToString();
        }

        private void ButtonChamar_Click(object sender, EventArgs e) {
            // Chamar Senha para tal Guichê
            numChamaGuiche = int.Parse(textBoxGuiche.Text);
            Guiche gAchou = listaGuiches.ListaGuiches.Find(ga => ga.Id == numChamaGuiche);

            if (gAchou != null) gAchou.chamar(listaSenhas.FilaSenhas);
            else MessageBox.Show("Este Guiche não existe!");           
        }

        private void ButtonListarAtendimentos_Click(object sender, EventArgs e) {
            // Listar Atendimentos
            listBoxAtendimentos.Items.Clear();

            if (listaGuiches.ListaGuiches[int.Parse(textBoxGuiche.Text) - 1].Atendimentos.Count >= 1) { 
                listBoxAtendimentos.Items.Add("--------------------------------------------------------------------------------------------------------------");
                listBoxAtendimentos.Items.Add("  Senha\t|   \tGerado\t\t| \tAtendimento ");
                listBoxAtendimentos.Items.Add("--------------------------------------------------------------------------------------------------------------");

                    foreach (Senha s in listaGuiches.ListaGuiches[int.Parse(textBoxGuiche.Text) - 1].Atendimentos) {
                        listBoxAtendimentos.Items.Add(s.dadosCompletos());
                    }
               
            } else {
                listBoxAtendimentos.Items.Add("Lista de Atendimentos Vazia");
            }

        }
    }
}
