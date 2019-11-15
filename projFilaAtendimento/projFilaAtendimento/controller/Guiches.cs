using projFilaAtendimento.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaAtendimento.controller {
    class Guiches {
        private List<Guiche> listaGuiches;

        internal List<Guiche> ListaGuiches { 
            get => listaGuiches; 
            set => listaGuiches = value; 
        }

        public Guiches() {
            this.ListaGuiches = new List<Guiche>();
        }
        public void adicionar(Guiche guiche) {
            this.ListaGuiches.Add(guiche);
        }
    }
}
