using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.model {
    class Garagem {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        public int Id { 
            get => id; 
            set => id = value; 
        }
        public string Local { 
            get => local; 
            set => local = value; 
        }
        internal Stack<Veiculo> Veiculos { 
            get => veiculos; 
            set => veiculos = value; 
        }

        public Garagem(int id, string local) {
            this.Id = id;
            this.Local = local;
        }
        public int qtdeDeVeiculos() {
            return 1;
        }
        public int potencialDeTransporte() {
           
            return 1;
        }
    }
}
