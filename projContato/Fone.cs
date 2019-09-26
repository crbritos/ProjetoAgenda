using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projContato
{
    public class Fone
    {
        #region Atributos
        private string numero;
        private string tipo;
        #endregion

        #region Propriedades
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        #region Construtores
        public Fone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        public Fone()
            : this("", "")
        { }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return string.Format("Número: {0}\nTipo: {1}",
                this.numero, this.tipo);
        }
        #endregion
    }
}
