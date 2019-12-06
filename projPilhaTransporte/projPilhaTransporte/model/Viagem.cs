using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.model {
    class Viagem {
        private int id;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;

        public int Id { get => id; set => id = value; }
        internal Garagem Origem { 
            get => origem; 
            set => origem = value; 
        }
        internal Garagem Destino { 
            get => destino; 
            set => destino = value; 
        }
        internal Veiculo Veiculo { 
            get => veiculo;
            set => veiculo = value; 
        }

        public Viagem(int id, Garagem o, Garagem d, Veiculo v) {
            this.Id = id;
            this.Origem = o;
            this.Destino = d;
            this.Veiculo = v;
        }
    }
}
