using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.model {
    class Transporte {
        private Veiculo veiculo;
        private int qtdeTransportada;

        public int QtdeTransportada { 
            
            get => qtdeTransportada; 
            set => qtdeTransportada = value; 
        }
        internal Veiculo Veiculo { 
            get => veiculo; 
            set => veiculo = value; 
        }

        public Transporte(Veiculo veiculo, int qtdeTransportadora) {

        }
    }
}
