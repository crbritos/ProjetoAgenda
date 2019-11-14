using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projListaLivros {
    class Program {

        Livro livro;
        Livros livros = new Livros();
        Exemplar exemplar;

        static void Main(string[] args) {
            Program p = new Program();
            p.carregaMenu();
                
        }
        private void exibeMenu() {
            Console.WriteLine(
                "0. Sair\n" +
                "1. Adicionar livro\n" +
                "2. Pesquisar livro (sintético)\n" +
                "3. Pesquisar livro (analítico)\n" +
                "4. Adicionar exemplar\n" +
                "5. Registrar empréstimo\n" +
                "6. Registrar devolução\n" 
                );
        }
        private void carregaMenu() {
            int opcao;

            exibeMenu();

            Console.Write("Digite a opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    // Adicionar Livro
                    adicionaLivro();
                    //continua();
                    carregaMenu();
                    break;
                case 2:
                    // Pesquisar Livro Sintético
                    pesquisaLivroSintetico();
                    //continua();
                    carregaMenu();
                    break;
                case 3:
                    // Pesquisar Livro Analítico
                    pesquisaLivroAnalitico();
                    //continua();
                    carregaMenu();
                    break;
                case 4:
                    // Adicionar Exemplar
                    adicionaExemplar();
                    //continua();
                    carregaMenu();
                    break;
                case 5:
                    // Registrar Empréstimo
                    registraEmprestimo();
                    //continua();
                    carregaMenu();
                    break;
                case 6:
                    // Registrar Devolução
                    registraDevolucao();
                    //continua();
                    carregaMenu();
                    break;
                case 0:
                    // Sair
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\t!! [Opção inválida] !!");
                    carregaMenu();
                    break;
            }

        }
        private void adicionaLivro() {
            int isbn; string titulo, autor, editora;

            Console.Write("Digite o isbn: ");
            isbn = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo: ");
            titulo = Console.ReadLine();

            Console.Write("Digite o autor: ");
            autor = Console.ReadLine();

            Console.Write("Digite o editora: ");
            editora = Console.ReadLine();

            livro = new Livro(isbn, titulo, autor, editora);
            livros.adicionar(livro);
        }
        private void pesquisaLivroSintetico() {
            int isbn;

            Console.Write("Digite o isbn do livro: ");
            isbn = int.Parse(Console.ReadLine());

            if(livros.Acervo[isbn - 1].qtdeExemplares() == 0) {
                Console.WriteLine("Nenhum exemplar deste livro foi registrado!");
            } else {
                Console.WriteLine(
                "Titulo: " + livros.Acervo[isbn - 1].Titulo +
                "\nAutor: " + livros.Acervo[isbn - 1].Autor +
                "\nEditora: " + livros.Acervo[isbn - 1].Editora +
                "\nTotal de exemplares: " + livros.Acervo[isbn - 1].qtdeExemplares() +
                "\nDisponiveis: " + livros.Acervo[isbn - 1].qtdeDisponiveis() +
                "\nEmprestimos: " + livros.Acervo[isbn - 1].qtdeEmprestimos() +
                "\nDisponibilidade: " + livros.Acervo[isbn - 1].percDisponibilidade() + "%"
                );
            }
            
        }
        private void pesquisaLivroAnalitico() {
            int isbn;

            Console.Write("Digite o isbn do livro: ");
            isbn = int.Parse(Console.ReadLine());

            if (livros.Acervo[isbn - 1].qtdeExemplares() == 0) {
                Console.WriteLine("Nenhum exemplar deste livro foi registrado!");
            } else {
                Console.WriteLine(
                "Titulo: " + livros.Acervo[isbn - 1].Titulo +
                "\nAutor: " + livros.Acervo[isbn - 1].Autor +
                "\nEditora: " + livros.Acervo[isbn - 1].Editora +
                "\nTotal de exemplares: " + livros.Acervo[isbn - 1].qtdeExemplares() +
                "\nDisponiveis: " + livros.Acervo[isbn - 1].qtdeDisponiveis() +
                "\nEmprestimos: " + livros.Acervo[isbn - 1].qtdeEmprestimos() +
                "\nDisponibilidade: " + livros.Acervo[isbn - 1].percDisponibilidade() + "%" +
                "\nExemplares:"
                );

                foreach (Exemplar ex in livros.Acervo[isbn - 1].Exemplares) {
                    // Tombo do Exemplar
                    Console.WriteLine(
                        "\tExemplar (" + ex.Tombo + "): ");

                    // Status do Exemplar
                    if (ex.disponivel()) Console.WriteLine("\t - Status: Disponivel");
                    else Console.WriteLine("\t - Status: Emprestado!");

                    Console.WriteLine("\t - Nº de emprestimos: " + ex.Emprestimos.Count);

                    // Emprestimos realizados do Exemplar
                    foreach (Emprestimo emprestimo in ex.Emprestimos) {
                        Console.Write("\t - Data de empréstimo: " + emprestimo.DtEmprestimo.ToString() 
                            + (emprestimo.DtDevolucao.Equals(new DateTime(01,01,0001,00,00,00)) ? 
                            " | Data de devolução: Pendente" : 
                            " | Data de devolução: " + emprestimo.DtDevolucao.ToString()));
                    }
                }
 
            }
        }
        private void adicionaExemplar() {
            int tombo, isbn;

            Console.Write("Digite o isbn do livro: ");
            isbn = int.Parse(Console.ReadLine());

            if (livro.Exemplares == null) tombo = 1;
            else tombo = livros.Acervo[isbn - 1].qtdeExemplares() + 1;
            Console.WriteLine("\tTombo definido: " + tombo);


            exemplar = new Exemplar(tombo);
            livros.Acervo[isbn - 1].adicionarExemplar(exemplar);
            
        }
        private void registraEmprestimo() {
            int isbn, tombo;

            Console.Write("Digite o isbn do livro: ");
            isbn = int.Parse(Console.ReadLine());

            Console.Write("Digite o tombo do exemplar: ");
            tombo = int.Parse(Console.ReadLine());
         
            if (livros.Acervo[isbn - 1].Exemplares[tombo - 1].emprestar()) Console.WriteLine("Empréstimo efetuado!");
            else Console.WriteLine("Exemplar indisponivel");
        }
        private void registraDevolucao() {
            int isbn, tombo;

            Console.Write("Digite o isbn do livro: ");
            isbn = int.Parse(Console.ReadLine());

            Console.Write("Digite o tombo do exemplar: ");
            tombo = int.Parse(Console.ReadLine());

            if (livros.Acervo[isbn - 1].Exemplares[tombo - 1].devolver()) Console.WriteLine("Devolução efetuada!");
            else Console.WriteLine("Exemplar não emprestado!");
        }
        private void continua() {
            Console.WriteLine("Deseja continuar? Sim para continuar ou outra tecla para sair: ");
            string continua = Console.ReadLine();

            if (continua.Equals("sim", StringComparison.InvariantCultureIgnoreCase) || continua.Equals("s", StringComparison.InvariantCultureIgnoreCase))
                carregaMenu();
            else
                Environment.Exit(0);
        }
    }
}
