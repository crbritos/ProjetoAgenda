using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Exemplar {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo { 
            get => tombo; 
            set => tombo = value; 
        }
        public List<Emprestimo> Emprestimos { 
            get => emprestimos; 
            set => emprestimos = value; 
        }

        public Exemplar(int tombo) {
            this.Tombo = tombo;
            this.Emprestimos = new List<Emprestimo>();
        }

        public bool emprestar() {
            if (qtdeEmprestimos() == 0 || Emprestimos[qtdeEmprestimos() - 1].DtDevolucao != new DateTime(01, 01, 0001, 00, 00, 00)) {
                Emprestimos.Add(new Emprestimo(DateTime.Now));
                return true;
            }
               
            return false;
        }
        public bool devolver() {
            if (Emprestimos[qtdeEmprestimos() - 1].DtEmprestimo == new DateTime(01, 01, 0001, 00, 00, 00)) return false;

            Emprestimos[qtdeEmprestimos() - 1].DtDevolucao = DateTime.Now;
            return true;

        }
        public bool disponivel() {
            if (Emprestimos[qtdeEmprestimos() - 1].DtDevolucao != new DateTime(01,01,0001,00,00,00)) return true;
            return false;
        }
        public int qtdeEmprestimos() {
            if(Emprestimos == null) return 0;
            return Emprestimos.Count;
        }

    }
}
