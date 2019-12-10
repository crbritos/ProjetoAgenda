using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento.model {
    class Medicamento {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        Medicamento() {
            this.lotes = new Queue<Lote>();
        }
        Medicamento(int id, string nome, string laboratorio) {
            this.Id = id;
            this.Nome = nome;
            this.Laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }

        public int qtdeDisponivel() {

            return 1;
        }
        public void comprar(Lote lote) {

            this.lotes.Enqueue(lote);
        }
        public bool vender(int qtde) {
           
            return false;
        }
        public string toString() {
            return id + " - " + Nome + " - " + Laboratorio + " - " + qtdeDisponivel();
        }
        public override bool Equals(object obj) {
            
            if (obj.Equals(this.Id)) return true;
            else return false;
        }

    }
}
