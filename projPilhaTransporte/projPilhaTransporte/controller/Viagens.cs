using projPilhaTransporte.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.controller {
    class Viagens {
        private Queue<Viagem> viagens;

        internal Queue<Viagem> filaViagens { get => viagens; set => viagens = value; }

        public void incluir(Viagem viagem) {
            this.filaViagens.Enqueue(viagem);
        } 
    }
}
