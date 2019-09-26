using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projContato
{
    public class Contatos
    {
        private List<Contato> meusContatos;

        public List<Contato> MeusContatos
        {
            get { return meusContatos; }
        }

        public Contatos()
        {
            meusContatos = new List<Contato>();
        }

        public void adicionar(Contato c)
        {
            this.meusContatos.Add(c);
        }

        public Contato pesquisar(Contato c)
        {
            Contato contatoAchado;
            contatoAchado = new Contato();
            foreach (Contato contato in this.meusContatos)
                if (contato.Equals(c))
                    contatoAchado = contato;
            return contatoAchado;
        }

        public bool alterar(Contato c)
        {
            int posicao;
            posicao = this.meusContatos.IndexOf(c);
            if (posicao > -1)
            {
                this.meusContatos.RemoveAt(posicao);
                this.meusContatos.Insert(posicao, c);
            }
            return (posicao > -1);
        }

        public bool remover(Contato c)
        {
            bool podeRemover;
            podeRemover = (this.meusContatos.IndexOf(c) > -1);
            if (podeRemover)
                this.meusContatos.RemoveAt(this.meusContatos.IndexOf(c));
            return podeRemover;
        }


    }
}

