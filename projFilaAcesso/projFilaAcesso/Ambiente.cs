using System;
using System.Collections.Generic;
using System.Text;

namespace projFilaAcesso
{
    class Ambiente {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public int Id { 
            get => id; 
            set => id = value; 
        }
        public string Nome { 
            get => nome;
            set => nome = value;
        }
        internal Queue<Log> Logs { 
            get => logs; 
            set => logs = value; 
        }

        public Ambiente() { }
        public Ambiente(int id) {
            this.Id = id;
        }
        public Ambiente(int id, string nome) {
            this.Id = id;
            this.Nome = nome;
            this.Logs = new Queue<Log>();
        }

        public void registrarLog(Log log) {
            if(Logs.Count < 100) {
                this.Logs.Enqueue(log);
            } else {
                this.Logs.Dequeue();
                this.Logs.Enqueue(log);
            }
        }
    }
}
