using projFilaMedicamento.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento.controller {
    class Medicamentos {
        private List<Medicamento> listaMedicamentos;

        internal List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        Medicamentos() { }
        
        public void adicionar(Medicamento medicamento) {
  
        }
        public bool deletar(Medicamento medicamento) {
       
            return false;
        }
        public Medicamento pesquisar(Medicamento medicamento) {
            
            return medicamento;
        }
            
    }
}
