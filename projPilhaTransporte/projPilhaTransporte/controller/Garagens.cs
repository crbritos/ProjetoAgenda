using projPilhaTransporte.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte.controller {
    class Garagens {
        private List<Garagem> garagens = new List<Garagem>();
        private bool jornadaAtiva;

        internal List<Garagem> listaGaragens { get => garagens; set => garagens = value; }
        public bool JornadaAtiva { get => jornadaAtiva; set => jornadaAtiva = value; }

        public void incluir(Garagem garagem) {
            this.listaGaragens.Add(garagem);
            this.JornadaAtiva = false;
        }
        public bool iniciarJornada(Veiculos veiculos) {
            int indexG = 0;
            if(listaGaragens.Count < 2) {
                return false;
            } else {
                foreach(Veiculo v in veiculos.listaVeiculos) {
                    listaGaragens[indexG].Veiculos.Push(v);
                    if(listaGaragens.Count < indexG) {
                        indexG = 0;
                    }
                }
                this.JornadaAtiva = true;
                return true;
            }

        }
        public List<Transporte> encerrarJornada(Viagens viagens, Veiculos veiculos, List<Transporte> transportes) {
            this.JornadaAtiva = false;
            int total = 0;
            
            foreach(Veiculo v in veiculos.listaVeiculos) {
                total = viagens.filaViagens.Peek().Veiculo.Lotacao * viagens.filaViagens.Count(x => x.Veiculo == v);
                transportes.Add(new Transporte(v, total));
                viagens.filaViagens.Dequeue();
            }

            return transportes;
        }
    }
}
