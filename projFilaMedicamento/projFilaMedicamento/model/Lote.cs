using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento.model {
    class Lote {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        Lote() {}
        Lote(int id, int qtde, DateTime venc) {
            this.Id = id;
            this.Qtde = qtde;
            this.Venc = venc;
        }

        public string toString() {
            return Id + " - " + Qtde + " - " + Venc;
        }
     
    }
}
