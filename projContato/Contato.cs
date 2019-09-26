using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projContato
{
    public class Contato
    {
        #region Atributos
        private string email;
        private string nome;
        private List<Fone> fones;
        #endregion

        #region Propriedades
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public List<Fone> Fones
        {
            get { return fones; }
        }
        #endregion

        #region Construtores
        public Contato(string email, string nome, List<Fone> fones)
        {
            this.email = email;
            this.nome = nome;
            this.fones = fones;
        }

        public Contato(string email): this(email, "", new List<Fone>())
        { }

        public Contato()
            : this("", "", new List<Fone>())
        { }
        #endregion

        #region Metodos
        public void adicionarFone(Fone fone)
        {
            this.fones.Add(fone);
        }
        public void removerFone(Fone fone)
        {
            this.fones.Remove(fone);
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            string osFones = "";
            foreach (Fone f in this.fones)
                osFones += f.ToString() + '\n';

            return string.Format("E-mail: {0}\nNome: {1}\nFones: {2}", 
                this.email, this.nome, osFones);
        }

        public override bool Equals(object obj)
        {
            return (this.email == ((Contato)obj).email);
        }
        #endregion

    }
}
