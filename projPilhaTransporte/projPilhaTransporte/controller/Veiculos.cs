using projPilhaTransporte.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.controller {
    class Veiculos {
        List<Veiculo> veiculos = new List<Veiculo>();

        public List<Veiculo> listaVeiculos { get => veiculos; set => veiculos = value; }

        public void incluir(Veiculo veiculo) {
            this.listaVeiculos.Add(veiculo);
        }
    }
}
