using AgendaEF_CF.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaEF_CF.Views
{
    internal class ViewPhone
    {
        public void MenuPhone()
        {
            PhoneController phone = new PhoneController();
            int op;
            do
            {
                Console.WriteLine("\n\t\t*** Menu Telefones***");
                Console.WriteLine("\n1-Cadastrar Telefone" +
                                  "\n2-Consultar Telefone" +
                                  "\n3-Localizar Telefone" +
                                  "\n4-Remover Telefone" +
                                  "\n5-Editar Telefone" +
                                  "\n0-Voltar ao Menu Inicial");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        phone.InsertPhone();
                        Console.Clear();

                        break;
                    case 2:
                        phone.ListPhone();
                        Console.Clear();

                        break;
                    case 3:
                        phone.UniquePhone();
                        Console.Clear();

                        break;
                    case 4:
                        phone.RemoverPhone();
                        Console.Clear();
                        break;
                    case 5:
                        phone.UpdatePhone();
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
