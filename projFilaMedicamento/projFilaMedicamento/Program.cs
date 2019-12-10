using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento {
    class Program {
        static void Main(string[] args) {
            
        }

        public void exibeMenu() {
            Console.WriteLine(
                "--------------------------------------------------------------------" +
                "| 0. Finalizar processo                                            |" +
                "| 1. Cadastrar medicamento                                         |" +
                "| 2. Consultar medicamento (sintético: informar dados)             |" +
                "| 3. Consultar medicamento (analítico: informar dados1 + lotes)    |" +
                "| 4. Comprar medicamento (cadastrar lote)                          |" +
                "| 5. Vender medicamento (abater do lote mais antigo)               |" +
                "| 6. Listar medicamentos (informando dados sintéticos)             |" +
                "--------------------------------------------------------------------" +
                "-> Digite a opção: "
                );
        }
        public void cadastraMedicamento() { }
        public void consultaMedicamentoSintetico() {
            
        }
        public void consultaMedicamentoAnalitico() {
        }
        public void compraMedicamento() { }
        public void vendeMedicamento() { }
        public void listaMedicamento() { }

    }
}
