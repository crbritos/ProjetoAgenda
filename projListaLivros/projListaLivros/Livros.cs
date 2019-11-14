using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Livros {
        private List<Livro> acervo = new List<Livro>();

        public List<Livro> Acervo 
        { 
            get => acervo; 
            set => acervo = value; 
        }

        public void adicionar(Livro livro) {
            this.acervo.Add(livro);
        }
        public Livro pesquisar(Livro livro) {
            return acervo.Find(l => l.Equals(livro));
        }
    }
}
