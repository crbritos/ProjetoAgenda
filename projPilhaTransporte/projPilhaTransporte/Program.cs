using projPilhaTransporte.controller;
using projPilhaTransporte.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilhaTransporte {
    class Program {
        Veiculos veiculos = new Veiculos();
        Garagens garagens = new Garagens();
        Viagens viagens = new Viagens();
        List<Transporte> transportes = new List<Transporte>();

        static void Main(string[] args) {

        }
        public void menu() {
            Console.Write("1. Cadastrar veículo" + "\n" +
                          "2. Cadastrar garagem" + "\n" +
                          "3. Iniciar jornada" + "\n" +
                          "4. Encerrar jornada" + "\n" +
                          "5. Liberar viagem" + "\n" +
                          "6. Listar veiculos na garagem" + "\n" +
                          "7. Informar quantidade de viagens realizadas" + "\n" +
                          "8. Listar viagens realizadas" + "\n" +
                          "9. Informar quantidade de passageiros de uma viagem");
        }
        public void cadastrarVeiculo() {
            int id, lotacao;
            string placa;

            Console.Write("Digite o id do veículo: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine();

            Console.Write("Digite a lotação do veículo: ");
            lotacao = int.Parse(Console.ReadLine());

            veiculos.incluir(new Veiculo(id, placa, lotacao));
        }
        public void cadastrarGaragem() {
            int id;
            string local;

            Console.Write("Digite o id da garagem: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Digite o local da garagem: ");
            local = Console.ReadLine();

            garagens.incluir(new Garagem(id, local));
        }
        public void iniciarJornada() {
            if(garagens.iniciarJornada(veiculos)) Console.WriteLine("Jornada iniciada!");
            else Console.WriteLine("Não existem garagens suficientes para iniciar uma jornada!");
        }
        public void encerrarJornada() {
            _ = garagens.encerrarJornada(viagens, veiculos, transportes);
        }
        public void liberarViagem() {
            int idO, idD;

            Console.Write("Digite o id da garagem de origem: ");
            idO = int.Parse(Console.ReadLine());

            Console.Write("Digite o id da garagem de destino: ");
            idD = int.Parse(Console.ReadLine());

            Garagem gOrigem = garagens.listaGaragens.Find(g => g.Id == idO);
            Garagem gDestino = garagens.listaGaragens.Find(g => g.Id == idD);

            Veiculo v = garagens.listaGaragens[idO].Veiculos.Peek();
            garagens.listaGaragens[idO].Veiculos.Pop();
            garagens.listaGaragens[idD].Veiculos.Push(v);

            viagens.incluir(new Viagem(1, gOrigem, gDestino, v));
        }
        public void listarVeiculosNaGaragem() {
            int idGaragem;

            Console.Write("Digite o id da garagem: ");
            idGaragem = int.Parse(Console.ReadLine());

            foreach(Veiculo v in garagens.listaGaragens[idGaragem].Veiculos) {
                Console.WriteLine("ID: " + v.Id + "\nPlaca: " + v.Placa + "\nLotação: " + v.Lotacao);
            }
        }
        public void infoQuantidadeDeViagens() {
            Console.WriteLine("Quantidade de viagens: " + viagens.filaViagens.Count);
        }
        public void listarViagensRealizadas() {
            foreach(Viagem v in viagens.filaViagens) {
                Console.WriteLine("ID da Viagem: " + v.Id 
                    + "\nOrigem: " + v.Origem + "\nDestino" 
                    + v.Destino + "\n-> ID do Veiculo" + v.Veiculo.Id + "\n-> Placa:" 
                    + v.Veiculo.Placa + "\n-> Lotação: " + v.Veiculo.Lotacao);
            }
        }
        public void infoQuantidadeDePassageiros() {

        }
    }
}
