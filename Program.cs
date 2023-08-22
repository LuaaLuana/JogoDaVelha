using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Program
    {
        public static string[,] matriz = new string[3, 3];
        
        static void Main()
        {       
           Console.WriteLine("Seja bem-vindo(a) ao Jogo da Velha.\nDigite a posição (1-9) que deseja marcar.\nBom Jogo."); //instruções           
            for (int i = 0; i < 3; i++) //criando a matriz
            {
                for (int j = 0; j < 3; j++)
                    matriz[i, j] = "[ ]";
            }
            Jogo();            
        }
        public static void Jogo()
        {                    
           Jogador();
        }
        public static void Jogador()   
        {
            Console.WriteLine("Sua vez:");
            int resposta = int.Parse(Console.ReadLine());
            Random casaInim = new Random(); //jogada do adversário
            int casa = casaInim.Next(10);

            if (resposta == 1 && matriz[0, 0] == "[ ]")
            {
                matriz[0, 0] = "[X]";
            }
            else if (resposta == 2 && matriz[0, 1] == "[ ]")
            {
                matriz[0, 1] = "[X]";
            }
            else if (resposta == 3 && matriz[0, 2] == "[ ]")
            {
                matriz[0, 2] = "[X]";
            }
            else if (resposta == 4 && matriz[1, 0] == "[ ]")
            {
                matriz[1, 0] = "[X]";
            }
            else if (resposta == 5 && matriz[1, 1] == "[ ]")
            {
                matriz[1, 1] = "[X]";
            }
            else if (resposta == 6 && matriz[1, 2] == "[ ]")
            {
                matriz[1, 2] = "[X]";
            }
            else if (resposta == 7 && matriz[2, 0] == "[ ]")
            {
                matriz[2, 0] = "[X]";
            }
            else if (resposta == 8 && matriz[2, 1] == "[ ]")
            {
                matriz[2, 1] = "[X]";
            }
            else if (resposta == 9 && matriz[2, 2] == "[ ]")
            {
                matriz[2, 2] = "[X]";
            }
            else
            {
                Console.WriteLine("Impossível marcar nesta casa, tente outra.");
                Jogador();
            };

            Rodada();
            Inimigo(casa);
        }

        public static void Rodada()
        {
            for (int i = 0; i < 3; i++) //imprimindo a matriz
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
            Final();
        }

        public static void Inimigo(int casa)
        {           
            if (casa == 1 && matriz[0, 0] == "[ ]")
            {
                matriz[0, 0] = "[O]";
            }
            else if (casa == 2 && matriz[1, 0] == "[ ]")
            {
                matriz[1, 0] = "[O]";
            }
            else if (casa == 3 && matriz[2, 0] == "[ ]")
            {
                matriz[2, 0] = "[O]";
            }
            else if (casa == 4 && matriz[0, 1] == "[ ]")
            {
                matriz[0, 1] = "[O]";
            }
            else if (casa == 5 && matriz[1, 1] == "[ ]")
            {
                matriz[1, 1] = "[O]";
            }
            else if (casa == 6 && matriz[2, 1] == "[ ]")
            {
                matriz[2, 1] = "[O]";
            }
            else if (casa == 7 && matriz[0, 2] == "[ ]")
            {
                matriz[0, 2] = "[O]";
            }
            else if (casa == 8 && matriz[1, 2] == "[ ]")
            {
                matriz[1, 2] = "[O]";
            }
            else if (casa == 9 && matriz[2, 2] == "[ ]")
            {
                matriz[2, 2] = "[O]";
            }
            else
            {
                casa++;
                Inimigo(casa);
            };
            Console.WriteLine("Jogada do Adversário:");
            Rodada();
            Jogador();
        }

        public static void Final()
        {   
            //Vitória
            if (matriz[0, 0] == "[X]" && matriz[0, 1] == "[X]" && matriz[0, 2] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[1, 0] == "[X]" && matriz[1, 1] == "[X]" && matriz[1, 2] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[2, 0] == "[X]" && matriz[2, 1] == "[X]" && matriz[2, 2] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[0, 0] == "[X]" && matriz[1, 0] == "[X]" && matriz[2, 0] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[0, 1] == "[X]" && matriz[1, 1] == "[X]" && matriz[2, 1] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[0, 2] == "[X]" && matriz[1, 2] == "[X]" && matriz[2, 2] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[0, 0] == "[X]" && matriz[1, 1] == "[X]" && matriz[2, 2] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            } 
            else if (matriz[0, 2] == "[X]" && matriz[1, 1] == "[X]" && matriz[2, 0] == "[X]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            }

            //Derrota
            if (matriz[0, 0] == "[O]" && matriz[0, 1] == "[O]" && matriz[0, 2] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
            else if (matriz[1, 0] == "[O]" && matriz[1, 1] == "[O]" && matriz[1, 2] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
            else if (matriz[2, 0] == "[O]" && matriz[2, 1] == "[O]" && matriz[2, 2] == "[O]")
            {
                Console.WriteLine("Parabéns, você venceu!");
                Console.ReadLine();
            }
            else if (matriz[0, 0] == "[O]" && matriz[1, 0] == "[O]" && matriz[2, 0] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
            else if (matriz[0, 1] == "[O]" && matriz[1, 1] == "[O]" && matriz[2, 1] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
            else if (matriz[0, 2] == "[O]" && matriz[1, 2] == "[O]" && matriz[2, 2] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
            else if (matriz[0, 0] == "[O]" && matriz[1, 1] == "[O]" && matriz[2, 2] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
            else if (matriz[0, 2] == "[O]" && matriz[1, 1] == "[O]" && matriz[2, 0] == "[O]")
            {
                Console.WriteLine("Que pena, você perdeu!");
                Console.ReadLine();
            }
        }
    }
}
