using AgendaEF_CF.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaEF_CF.Views
{
    internal class ViewPerson
    {
        public void MenuPerson()
        {
            PersonController person = new PersonController();
            int op;
            do
            {
                Console.WriteLine("\n\t\t*** Menu Perssoas***");
                Console.WriteLine("\n1-Cadastrar Pessoas" +
                                  "\n2-Consultar Pessoas" +
                                  "\n3-Localizar Pessoa" +
                                  "\n4-Remover Pessoa" +
                                  "\n5-Editar Pessoa" +
                                  "\n0-Voltar ao Menu Inicial");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        person.InsertPerson();
                        Console.Clear();

                        break;
                    case 2:
                        person.ListPerson();
                        Console.Clear();

                        break;
                    case 3:
                        person.UniquePerson();
                        Console.Clear();

                        break;
                    case 4:
                        person.RemoverPerson();
                        Console.Clear();
                        break;
                    case 5:
                        person.UpdatePerson();
                        Console.Clear();
                        break;
                    default:
                        if (op < 0 || op > 5)
                        {

                            Console.WriteLine("\nOpção Invalida!!!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                }
            } while (op != 0);
        }
    }
}
