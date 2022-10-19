using AgendaEF_CF.Context;
using AgendaEF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaEF_CF.Controller
{
    internal class PhoneController
    {
        #region Insere Dados
        public void InsertPhone()
        {
            Console.WriteLine("\n*** Cadastrar Telefones ***");
            Telephone phone = new Telephone();
            Console.Write("\nNome: ");
            String nome = Console.ReadLine();

            Person find = new PersonContext().Persons.Find(nome);
            if (find != null)
            {
                using (var context1 = new PersonContext())
                {
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n*** Cadastrar Telefones ***");
                    phone.PersonId = nome;
                    Console.Write("\nTelefone: ");
                    phone.HomePhone = Console.ReadLine();
                    Console.Write("\nCelular: ");
                    phone.Mobile = Console.ReadLine();
                    context1.Phones.Add(phone);
                    context1.SaveChanges();
                    Console.WriteLine("\nTelefone Cadastrados com Sucesso...");
                    Thread.Sleep(2000);

                }

            }
            else
            {
                Console.WriteLine("\nPessoa Não Encontrada...");
                Console.WriteLine("\nPressione ENTER Para Continuar...");
                Console.ReadKey();
            }
        }
        #endregion

        #region Lista Todos
        public void ListPhone()
        {
            Console.Clear();
            Console.WriteLine("\n*** Consulta de Telefones ***");
            using (var context = new PersonContext())
            {
                var phones = new PersonContext().Phones.ToList();
                foreach (var item in phones)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion

        #region Listar Unico
        public void UniquePhone()
        {
            Console.Clear();
            using (var context = new PersonContext())
            {
                Console.WriteLine("\n*** Localizar Telefones ***");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                Telephone find = new PersonContext().Phones.Find(id);
                if (find != null)
                {
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("\nTelefones Não Encontrados...");
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                }
            }

        }
        #endregion
        #region Update
        public void UpdatePhone()
        {
            Console.Clear();
            using (var context = new PersonContext())
            {
                Console.WriteLine("\n*** ALterar Telefones ***");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                Telephone find = new PersonContext().Phones.Find(id);

                if (find != null)
                {
                    context.Entry(find).State = EntityState.Modified;
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nPressione Qualquer Tecla Para Continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n*** ALterar Telefones ***");
                    Console.Write("\nAlterar Telefone Residencial: ");
                    find.HomePhone = Console.ReadLine();
                    Console.Write("\nAlterar Celular: ");
                    find.Mobile = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nTelefones Editados Com Sucesso...");
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nTelefones Não Encontrados...");
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion

        #region Remove
        public void RemoverPhone()
        {
            Console.Clear();
            using (var context = new PersonContext())
            {
                Console.WriteLine("\n*** Remover Telefones ***");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                Telephone find = new PersonContext().Phones.Find(id);
                if (find != null)
                {
                    context.Entry(find).State = EntityState.Deleted;
                    context.Phones.Remove(find);
                    context.SaveChanges();
                    Console.WriteLine("\nTelefones Removidos com Sucesso...");
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nTelefones Não Encontrados...");
                    Console.WriteLine("\nPressione ENTER Para Continuar...");
                    Console.ReadKey();
                }
            }

        }
        #endregion

       
    }
}
