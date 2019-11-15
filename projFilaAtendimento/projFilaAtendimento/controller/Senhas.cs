using projFilaAtendimento.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaAtendimento.controller {
    class Senhas {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        public Senhas() {
            //this.ProximoAtendimento += 1;
            this.FilaSenhas = new Queue<Senha>();
        }
        public void gerar() {
            this.ProximoAtendimento += 1;
            this.FilaSenhas.Enqueue(
                new Senha(this.ProximoAtendimento));
        }
    }
}
