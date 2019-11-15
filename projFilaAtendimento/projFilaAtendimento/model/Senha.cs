using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaAtendimento.model {
    class Senha {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public Senha(int id) {
            this.Id = id;
            this.DataGerac = DateTime.Now;
            this.HoraGerac = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { 
            get => dataGerac; 
            set => dataGerac = value; 
        }
        public DateTime HoraGerac { 
            get => horaGerac; 
            set => horaGerac = value; 
        }
        public DateTime DataAtend { 
            get => dataAtend; 
            set => dataAtend = value; 
        }
        public DateTime HoraAtend { 
            get => horaAtend;
            set => horaAtend = value; 
        }

        public string dadosParciais() {
            return "    " + Id + "\t|    "
                + DataGerac.ToString("dd/MM/yyyy") + " - "
                + HoraGerac.ToString("HH:mm:ss");
        }
        public string dadosCompletos() {
            return "    " + Id + "\t|     "
                + DataGerac.ToString("dd/MM/yyyy") + " - "
                + HoraGerac.ToString("HH:mm:ss") + "\t|       "
                + DataAtend.ToString("dd/MM/yyyy") + " - "
                + HoraAtend.ToString("HH:mm:ss");
        }
    }
}
