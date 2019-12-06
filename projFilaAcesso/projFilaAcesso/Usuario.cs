using System;
using System.Collections.Generic;
using System.Text;

namespace projFilaAcesso
{
    class Usuario {
        private int id;
        private string nome;
        private List<Ambiente> ambientes = new List<Ambiente>();

        public int Id { 
            get => id; 
            set => id = value; 
        }
        public string Nome { 
            get => nome; 
            set => nome = value; 
        }
        internal List<Ambiente> Ambientes { 
            get => ambientes; 
            set => ambientes = value; 
        }

        public Usuario() { }
        public Usuario(int id) {
            this.Id = id;
        }
        public Usuario(int id, string nome) {
            this.Id = id;
            this.Nome = nome;
        }

        public bool concederPermissao(Ambiente ambiente) {
            if(Ambientes.Contains(ambiente)) {
                return false; 
            } else {
                Ambientes.Add(ambiente);
                return true;  
            }  
        }
        public bool revogarPermissao(Ambiente ambiente) {
            if(Ambientes.Contains(ambiente)) {
                Ambientes.RemoveAll(x => x.Id == ambiente.Id);
                return true;  
            } else {
                return false; 
            }
   
        }
    }
}
