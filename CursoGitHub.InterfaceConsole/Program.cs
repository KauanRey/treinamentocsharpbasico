using System;

namespace CursoGitHub.InterfaceConsole
{ //inicio do namespace
    internal class Program
    { //inicio da classe
        static void Main(string[] args)
        { //inicio do método
            /*
             * Main - principal
             * O método inicia-se com a letra maíscula
             *  
             */
            //Variável
            /*
             * É um espaço reservado na memória
             */
            /*Tipos de Dados
             * Inteiro - int
             * Real - double
             * Texto - string*/
            /*
             * + - Adição
             * - - Subtração
             * * - Multiplicação
             * / - Divição
             * % - mod (módulo de divisão)
             */
            string comando;
            string resposta = "git remote add origin";
            
            Console.WriteLine("Qual comando para iniciar o git?");
            comando = Console.ReadLine();
            string[] subcomando = comando.Split(' ');
           foreach (var item in subcomando)

            {
                Console.WriteLine(item);    
            }

            if (comando.Equals(resposta))
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Errou");
            }
            Console.WriteLine($"A resposta é {resposta}");
            Console.WriteLine("Alô Mundo!");
            Console.ReadKey();

        } //fim do método
    } //fim da classe
} //fim do namespace

