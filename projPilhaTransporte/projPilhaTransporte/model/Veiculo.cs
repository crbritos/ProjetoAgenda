using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.model {
    class Veiculo {
        private int id;
        private string placa;
        private int lotacao;

        public int Id { 
            get => id; 
            set => id = value; 
        }
        public string Placa { 
            get => placa; 
            set => placa = value; 
        }
        public int Lotacao { 
            get => lotacao;
            set => lotacao = value; 
        }

        public Veiculo(int id, string placa, int lotacao) {
            this.Id = id;
            this.Placa = placa;
            this.Lotacao = lotacao;
        }
    }
}
