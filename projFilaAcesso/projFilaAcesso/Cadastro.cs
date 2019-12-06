using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace projFilaAcesso
{
    class Cadastro {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Ambiente> ambientes = new List<Ambiente>();

        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public void adicionarUsuario(Usuario usuario) {
            this.Usuarios.Add(usuario);
        }
        public bool removerUsuario(Usuario usuario) { 
            if(pesquisarUsuario(usuario) != null) {
                this.Usuarios.RemoveAll(x => x.Id == usuario.Id);
                return true;
            } else {
                return false;
            }
        }
        public Usuario pesquisarUsuario(Usuario usuario) {
            Usuario user = (this.Usuarios.Find(u => u.Id == usuario.Id));
            return user; 
        }
        public void adicionarAmbiente(Ambiente ambiente) {
            this.Ambientes.Add(ambiente);
        }
        public bool removerAmbiente(Ambiente ambiente) {
            if(pesquisarAmbiente(ambiente) != null) {
                this.Ambientes.RemoveAll(x => x.Id == ambiente.Id);
                return true;
            } else {
                return false;
            }
        }
        public Ambiente pesquisarAmbiente(Ambiente ambiente) {
            Ambiente environment = (this.Ambientes.Find(a => a.Id == ambiente.Id));
            return environment;
        }
        public void upload() {
            using(StreamWriter writer = new StreamWriter("ambientes.csv",false)) {
                foreach(Ambiente ambiente in Ambientes) {
                    writer.WriteLine(ambiente.Id + ";" + ambiente.Nome);
                }
            }
            using(StreamWriter writer = new StreamWriter("usuarios.csv")) {
                foreach(Usuario usuario in Usuarios) {
                    writer.WriteLine(usuario.Id + ";" + usuario.Nome);
                }
            }
            using(StreamWriter writer = new StreamWriter("logs.csv")) {
                foreach(Ambiente ambiente in Ambientes) {
                    foreach(Log log in ambiente.Logs) {
                        writer.WriteLine(ambiente.Id + ";" + log.TipoAcesso + ";" + log.Usuario.Id  + ";" + log.DtAcesso);
                    }
                }
            }
        }
        public void download() {
            String linha;
            using(StreamReader sr = new StreamReader("ambientes.csv")) {    

                while((linha = sr.ReadLine()) != null) {
                    string[] linhas = linha.Split(";");
                    this.Ambientes.Add(new Ambiente(int.Parse(linhas[0]), linhas[1]));
                }
            }
            using(StreamReader sr = new StreamReader("usuarios.csv")) {    
                
                while((linha = sr.ReadLine()) != null) {
                    string[] linhas = linha.Split(";");
                    this.Usuarios.Add(new Usuario(int.Parse(linhas[0]), linhas[1]));
                }
            }
            using(StreamReader sr = new StreamReader("logs.csv")) {
             
                while((linha = sr.ReadLine()) != null) {
                    string[] linhas = linha.Split(";");
                    Usuario user = pesquisarUsuario(new Usuario(int.Parse(linhas[2])));
                    this.Ambientes[int.Parse(linhas[0])].Logs.Enqueue(new Log(DateTime.Parse(linhas[3]),bool.Parse(linhas[1]), user));
                }
            }
        }
    }
}
