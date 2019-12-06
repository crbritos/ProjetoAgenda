using System;
using System.Collections.Generic;
using System.Text;

namespace projFilaAcesso {
    class Log {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public DateTime DtAcesso { 
            get => dtAcesso; 
            set => dtAcesso = value;
        }
        public bool TipoAcesso { 
            get => tipoAcesso;
            set => tipoAcesso = value; 
        }
        internal Usuario Usuario { 
            get => usuario; 
            set => usuario = value; 
        }

        public Log(DateTime dtAcesso, bool tipoAcesso, Usuario usuario) {
            this.DtAcesso = dtAcesso;
            this.TipoAcesso = tipoAcesso;
            this.Usuario = usuario;
        }
    }
}
