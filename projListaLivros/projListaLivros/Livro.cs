using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Livro {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public int Isbn { 
            get => isbn; 
            set => isbn = value; 
        }
        public string Titulo { 
            get => titulo; 
            set => titulo = value; 
        }
        public string Autor { 
            get => autor; 
            set => autor = value; 
        }
        public string Editora
        {
            get => editora;
            set => editora = value;
        }

        public List<Exemplar> Exemplares { 
            get => exemplares; 
            set => exemplares = value; 
        }

        public Livro(int isbn, string titulo, string autor, string editora) {
            this.Isbn = isbn;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.Exemplares = new List<Exemplar>();
        }


        public void adicionarExemplar(Exemplar exemplar) {
            this.Exemplares.Add(exemplar);
        }
        public int qtdeExemplares() {
            return exemplares.Count;
        }
        public int qtdeDisponiveis() {
            int qtde = 0;
            foreach(Exemplar e in Exemplares) {
                if (e.disponivel())
                    qtde += 1;
            }
            return qtde;
        }
        public int qtdeEmprestimos() {
            if (qtdeExemplares() == 0 || qtdeExemplares() == null)
                return 0;
            return Exemplares[Isbn - 1].qtdeEmprestimos();
        }
        public double percDisponibilidade() {
            if (qtdeExemplares() == 0 || qtdeExemplares() == null)
                return 0;
            return (qtdeDisponiveis() * 100) / Exemplares.Count;
        }

    }
}
