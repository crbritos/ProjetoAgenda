using System;

namespace projFilaAcesso {
    class Program {

        int idAmbienteGerado = 1;
        int idUsuarioGerado = 1;
        Cadastro cadastro = new Cadastro();

        static void Main(string[] args) {
            Program proj = new Program();
            proj.carregaMenu();
        }
        public void exibeMenu() {
            Console.WriteLine(
                "----------------------------------------------" + "\n" +
                "| 0. Sair                                    |" + "\n" +
                "| 1. Cadastrar ambiente                      |" + "\n" +
                "| 2. Consultar ambiente                      |" + "\n" +
                "| 3. Excluir ambiente                        |" + "\n" +
                "| 4. Cadastrar usuario                       |" + "\n" +
                "| 5. Consultar usuario                       |" + "\n" +
                "| 6. Excluir usuario                         |" + "\n" +
                "| 7. Conceder permissão de acesso ao usuário |" + "\n" +
                "| 8. Revogar permissão de acesso ao usuário  |" + "\n" +
                "| 9. Registrar acesso                        |" + "\n" +
                "|10. Consultar logs de acesso                |" + "\n" +
                "----------------------------------------------");
        }
        public void carregaMenu() {
            Console.WriteLine("Carregando dados salvos...");

            try {
                cadastro.download();
                Console.WriteLine("Dados carregados com sucesso!");
            } catch (Exception e) {
            }

            exibeMenu();
            Console.Write("-> Digite a opção: ");
            
            try {
                int op = int.Parse(Console.ReadLine());
                opcaoDesejada(op);
            }catch(Exception e) {
                Console.WriteLine("--- Opção inválida! ---" + e.Message);
                carregaMenu();
            }
        }
        public void opcaoDesejada(int op) {
            switch(op) {
                case 0:
                   
                    saveAndClose();
                    break;
                case 1:
                
                    cadastraAmbiente();
                    pressToContinue();
                    break;
                case 2:
                    
                    consultaAmbiente();
                    pressToContinue();
                    break;
                case 3:
            
                    excluiAmbiente();
                    pressToContinue();
                    break;
                case 4:
                    
                    cadastraUsuario();
                    pressToContinue();
                    break;
                case 5:
                   
                    consultaUsuario();
                    pressToContinue();
                    break;
                case 6:
              
                    excluiUsuario();
                    pressToContinue();
                    break;
                case 7:
                   
                    concedePermissao();
                    pressToContinue();
                    break;
                case 8:
                   
                    revogaPermissao();
                    pressToContinue();
                    break;
                case 9:
                 
                    registraAcesso();
                    pressToContinue();
                    break;
                case 10:
                 
                    consultaLog();
                    pressToContinue();
                    break;
                default:
                  
                    Console.WriteLine("--- Opção inválida! ---");
                    carregaMenu();
                    break;
            }
        }
        public void cadastraAmbiente() {
         
            string nomeAmbiente;
            enviaMensagem(1,"nome do Ambiente", false);
            nomeAmbiente = Console.ReadLine();

            cadastro.adicionarAmbiente(new Ambiente(idAmbienteGerado, nomeAmbiente));
            enviaMensagem(2, "Ambiente", true);
            idAmbienteGerado += 1;
        }
        public void consultaAmbiente() {
            // Consultar ambiente 
            // ? talvez consulta o log de determinado ambiente
            int idAmbiente;
            enviaMensagem(1,"ID do Ambiente", false);
            idAmbiente = int.Parse(Console.ReadLine());
            Ambiente env;

            if((env = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente))) != null){
                Console.WriteLine("Ambiente encontrado!\n- Nome do ambiente: " + env.Nome);
            } else {
                if(cadastro.Ambientes.Count > 0) {
                    Console.WriteLine("Ambiente não encontrado, os ambientes existentes são:");
                    foreach(Ambiente environment in cadastro.Ambientes) {
                        Console.WriteLine(environment.Id + " - " + environment.Nome);
                    }
                } else {
                    Console.WriteLine("Nenhum ambiente foi cadastrado ainda!");
                }   
            }
        }
        public void excluiAmbiente() {
            // Excluir ambiente
            // Perguntar o id do Ambiente
            int idAmbiente;
            enviaMensagem(1,"ID do Ambiente", false);
            idAmbiente = int.Parse(Console.ReadLine());

            if(cadastro.removerAmbiente(new Ambiente(idAmbiente))) enviaMensagem(3,"Ambiente", true);
            else enviaMensagem(4, "Ambiente", true);
        }
        public void cadastraUsuario() {
           
            string nomeUsuario;
            enviaMensagem(1, "nome do Usuário", true);
            nomeUsuario = Console.ReadLine();

            cadastro.adicionarUsuario(new Usuario(idUsuarioGerado, nomeUsuario));
            enviaMensagem(2, "Usuário", true);
            idUsuarioGerado += 1;
        }
        public void consultaUsuario() {
            
            int idUsuario;
            enviaMensagem(1, "ID do Usuário", false);
            idUsuario = int.Parse(Console.ReadLine());

            cadastro.pesquisarUsuario(new Usuario(idUsuario));
            Usuario us;

            if((us = cadastro.pesquisarUsuario(new Usuario(idUsuario))) != null) {
                Console.WriteLine("Usuário encontrado!\n- Nome do usuário: " + us.Nome);
            } else {
                if(cadastro.Usuarios.Count > 0) {
                    Console.WriteLine("Usuário não encontrado, os ambientes existentes são:");
                    foreach(Usuario user in cadastro.Usuarios) {
                        Console.WriteLine(user.Id + " - " + user.Nome);
                    }
                } else {
                    Console.WriteLine("Nenhum usuário foi cadastrado ainda!");
                }
            }
        }
        public void excluiUsuario() {
           
            int idUsuario;
            enviaMensagem(1, "ID do Usuário", false);
            idUsuario = int.Parse(Console.ReadLine());

            if(cadastro.removerUsuario(new Usuario(idUsuario))) enviaMensagem(3,"Usuário", true);
            else enviaMensagem(4, "Usuário", true);
        }
        public void concedePermissao() {
            
            int idUsuario, idAmbiente;

            enviaMensagem(1, "ID do Ambiente", false);
            idAmbiente = int.Parse(Console.ReadLine());

            enviaMensagem(1, "ID do Usuário", false);
            idUsuario = int.Parse(Console.ReadLine());

            Usuario user = (cadastro.Usuarios.Find(u => u.Id == idUsuario));
            Ambiente ambiente = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente));
            if(user.concederPermissao(ambiente)) enviaMensagem(7, "concedida", true);
            else enviaMensagem(8, "concedida", true);
        }
        public void revogaPermissao() {
  
            int idUsuario, idAmbiente;

            enviaMensagem(1, "ID do Ambiente", false);
            idAmbiente = int.Parse(Console.ReadLine());

            enviaMensagem(1, "ID do Usuário", false);
            idUsuario = int.Parse(Console.ReadLine());

            Usuario user = (cadastro.Usuarios.Find(u => u.Id == idUsuario));
            Ambiente ambiente = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente));
            if(user.revogarPermissao(ambiente)) enviaMensagem(7, "revogada", true);
            else enviaMensagem(8, "revogada", true);
        }
        public void registraAcesso() {
            
            int idUsuario, idAmbiente;

            enviaMensagem(1, "ID do Ambiente", false);
            idAmbiente = int.Parse(Console.ReadLine());

            enviaMensagem(1, "ID do Usuário", false);
            idUsuario = int.Parse(Console.ReadLine());

            Usuario user = cadastro.pesquisarUsuario(new Usuario(idUsuario));
            Ambiente environment = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente));

            if(user.Ambientes.Contains(environment)) environment.registrarLog(new Log(DateTime.Now, true, user)); 
            else environment.registrarLog(new Log(DateTime.Now, false, user));
        }
        public void consultaLog() {
        

            int opcao; 
            enviaMensagem(9, "", false);
            opcao = int.Parse(Console.ReadLine());

            enviaMensagem(5,"LOG",true);
            foreach(Ambiente ambiente in cadastro.Ambientes) {
                foreach(Log log in ambiente.Logs) {
                   
                    switch(opcao) {
                        case 3:
                            enviaMensagem(10, log.TipoAcesso + " - " + log.Usuario.Nome + " - " + log.DtAcesso, true);
                            break;
                        case 1:
                            if(log.TipoAcesso == true) enviaMensagem(10, log.TipoAcesso + " - " + log.Usuario.Nome + " - " + log.DtAcesso, true);
                            break;
                        case 2:
                            if(log.TipoAcesso == false) enviaMensagem(10, log.TipoAcesso + " - " + log.Usuario.Nome + " - " + log.DtAcesso, true);
                            break;
                    }
                    
                }
            }
            enviaMensagem(6,"",true);
        }
        public void enviaMensagem(int opcao, String msg, bool pulaLinha) {
            switch(opcao) {
                case 1:
                  
                    msg = "Digite o " + msg + ": ";
                    break;
                case 2:
                   
                    msg = msg + " adicionado com sucesso!";
                    break;
                case 3:
                    
                    msg = msg + " excluido com sucesso!";
                    break;
                case 4:
                    
                    msg = "Não foi possível excluir o " + msg + ", pois ele não existe.";
                    break;
                case 5:
                    
                    msg = "----------" + msg + "----------";
                    break;
                case 6:
                  
                    msg = "-------------------------";
                    break;
                case 7:
           
                    msg = "Permissão " + msg + " com sucesso!";
                    break;
                case 8:
               
                    if(msg.Substring(0,8).Equals("concedida"))
                        msg = "A permissão não pode ser " + msg + ", pois o usuário já a possui!";
                    else
                        msg = "A permissão não pode ser " + msg + ", pois o usuário não a possui!";
                    break;
                case 9:
                    msg = "Para visualizar o Log dos ambientes, escolha uma das opções" + "\n" +
                          "1 - Logs de acessos autorizados" + "\n" +
                          "2 - Logs de acessos não autorizados" + "\n" +
                          "3 - Todos os Logs de acesso" + "\n" +
                          "-> Opção: ";
                    break;
                default:
                    
                    msg = msg;
                    break;
            }
            if(pulaLinha) Console.WriteLine(msg);
            else Console.Write(msg);
        }
        public void pressToContinue() {
            enviaMensagem(10, "Pressione qualquer tecla para continuar!", false);
            Console.ReadKey();
            carregaMenu();
        }
        public void saveAndClose() {
            Console.WriteLine("Aguarde! Salvando registros...");
            cadastro.upload();
            Console.WriteLine("Os registros foram salvos com sucesso!");
        }
    }
}
