using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();

            string opcao = "1";
            string opcao2 = "Sim";
            String a;

            while (opcao == "1")
            {
                Console.WriteLine("Por favor, informe o nome do item que deseja comprar: ");
                string itens = Console.ReadLine();

                Lista.Add(itens);
                Console.WriteLine("Deseja inserir mais algum item?  1-SIM | 2-Não");
                opcao = Console.ReadLine();
            }

            Console.WriteLine("a Lista de compras tem " + Lista.Count + " itens: ");

            for (int i = 0; i < Lista.Count; i++)

            {
                Console.WriteLine(Lista[i]);
            }

            Console.WriteLine("Gostaria de remover algum item da lista?   1--Sim  2--Não");
            opcao2 = Console.ReadLine();
            while (opcao2 == "1")
            {
                Console.WriteLine("Por favor, informe o nome do item que deseja remover: ");
                a = Console.ReadLine();

                if (Lista.Remove(a) == true)
                {
                    Lista.Remove(a);
                    Console.WriteLine("Item removido com sucesso");
                }
                else 
                {
                    Console.WriteLine("falha ao remover item");
                }

                Console.WriteLine("Deseja remover mais algum item ?  1-SIM | 2-Não");
                opcao2 = Console.ReadLine();

                Console.WriteLine(" A Lista de compras agora tem " + Lista.Count + "  itens :  ");
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        Console.WriteLine(Lista[i]);

                   
                }












          }
          
            Console.ReadKey();
            }

                    

            }
        }
    




