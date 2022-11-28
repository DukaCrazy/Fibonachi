using System;

namespace Fibonachi_OOP { 
    internal class Program {
        static void Main(string[] args) {

            /*As condições das variáveis estão na Classe Fibonachi.
              As condições das variáveis em execução estão no bloco main.
              O primeiro While esta para calcular a lógica do programa.
              O segundo While esta para verificar se o usuário gostária de refazer o calculo com um novo parâmetro.
              Após a conirmação no bloco if o terceiro While calcula a lógica proposta pelo usuário.
              Ao quebrar do segundo While no bloco else com uma resposta que não seja "0" o programa agradece ao usuário pelo uso do sistema.
              
              Sou iniciante e está lógica me deu um certo trabalho na parte do Segundo while pois estava retornando o bloco de agradecimento e depois me dava a opção de inserir um novo parâmetro que poderia 
             */

            Fibonachi Calc1;

            Calc1 = new Fibonachi();
            

            Calc1.FirstValor = 0;
            Calc1.SecondValor = 1;
            Console.Write("Digite um valor: ");
            Calc1.MenorQueX = int.Parse(Console.ReadLine());
            
            Calc1.Result = Calc1.FirstValor + Calc1.SecondValor;

            while (Calc1.Result<Calc1.MenorQueX) {

                Calc1.FirstValor = Calc1.SecondValor;
                Calc1.SecondValor = Calc1.Result;

                Calc1.Result = Calc1.FirstValor + Calc1.SecondValor;
                    
            }

            Console.WriteLine(Calc1);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Gostaria de fazer um novo calculo? \nDigite 0 para novo calculo\nDigite 1 para encerrar o programa: ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            string Continuar = "0", Terminar = "1", Resposta = Console.ReadLine();

            while (true)
            {
                if (Continuar.Equals(Resposta))
                {

                    Console.Write("Digite outro valor: ");

                    Calc1.MenorQueX = int.Parse(Console.ReadLine());
                    Calc1.FirstValor = 0; Calc1.SecondValor = 1;
                    Calc1.Result = Calc1.FirstValor + Calc1.SecondValor;

                    while (Calc1.Result < Calc1.MenorQueX)
                    {

                        Calc1.FirstValor = Calc1.SecondValor;
                        Calc1.SecondValor = Calc1.Result;

                        Calc1.Result = Calc1.FirstValor + Calc1.SecondValor;

                    }
                    Console.WriteLine(Calc1);
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------");
                    
                    Console.Write("Gostaria de fazer um novo calculo? \nDigite 0 para novo calculo\nDigite 1 para encerrar o programa: ");
                    Resposta = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------");
                }
                

                else if (Terminar.Equals(Resposta)) {
                    
                    break; }
            }
            Console.WriteLine("Obrigado por usar nosso sistema. Digite qualquer tecla para fechar nosso sistema.");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
            

        }




    }
}