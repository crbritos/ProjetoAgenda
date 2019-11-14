using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Emprestimo {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public DateTime DtEmprestimo { 
            get => dtEmprestimo; 
            set => dtEmprestimo = value; 
        }
        public DateTime DtDevolucao { 
            get => dtDevolucao; 
            set => dtDevolucao = value; 
        }

        public Emprestimo(DateTime dtEmp, DateTime dtDev) {
            this.DtEmprestimo = dtEmp;
            this.DtDevolucao = dtDev;
        }
        public Emprestimo(DateTime dtEmp) : this(dtEmp, new DateTime()) { }


    }
}