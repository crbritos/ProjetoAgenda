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
    public partial class FormLista : Form {
        Contatos lista;
        public FormLista(Contatos contatos) {
            InitializeComponent();
           this.lista = contatos;
        }

        private void FormLista_Load(object sender, EventArgs e) {
            foreach(Contato c in lista.MeusContatos) {
                dataGridViewContatos.Rows.Add(c.Email,c.Nome,c.Fones.ToString());
            }
        }
    }
}
