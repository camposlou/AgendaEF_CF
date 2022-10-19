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
    internal class PersonController
    {
        public void InsertPerson()
        {
            #region INSERT
            Console.Clear();
            Console.WriteLine(">>>Cadastrar Pessoas<<<");

            using (var context = new PersonContext())
            {
                Person person = new Person();
                Console.Write("\nNome: ");
                string name = Console.ReadLine().ToUpper();
                Person find = new PersonContext().Persons.FirstOrDefault(c => c.Name == name);
                if (find != null)
                {

                    Console.Clear();
                    Console.WriteLine("Este nome já esta cadastrado!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    

                }
                Console.Write("Email: ");
                person.Mail = Console.ReadLine();
                context.Persons.Add(person);
                context.SaveChanges();

                Console.WriteLine("Cadastro Realizado com sucesso...");
                Console.ReadKey();
            }
        }
        #endregion

        #region LISTA TODOS
        public void ListPerson()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Lista de Cadastros<<<");
            using (var context = new PersonContext())
            {
                var persons = new PersonContext().Persons.ToList();
                foreach (var item in persons)
                {
                    Console.Write(item.ToString());
                }
            }
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();
        }
        #endregion

        #region LISTAR UNICO
        public void UniquePerson()
        {
            Console.Clear();
            using (var context = new PersonContext())
            {
                Console.WriteLine("\n<<<Localizar Pessoa<<<");
                Console.Write("\nNome: ");
                string name = Console.ReadLine().ToUpper();
                Person find = new PersonContext().Persons.Find(name);
                if (find != null)
                {
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nPessoa não encontrada...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion

        #region ATUALIZAR

        public void UpdatePerson()
        {
            Console.Clear();
            using (var context = new PersonContext())
            {
                Console.WriteLine("\n>>>Alterar Cadastro<<<");
                Console.WriteLine("\nDigite o nome da pessoa que deseja alterar os campos: ");
                Console.Write("\nNome: ");
                string name = Console.ReadLine().ToUpper();
                Person find = new PersonContext().Persons.Find(name);
                if (find != null)
                {
                    context.Entry(find).State = EntityState.Modified;
                    Console.Write("\nAlterar Email: ");
                    find.Mail = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nCadastro alterado com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                
                else
                {
                    Console.WriteLine("\nPessoa não encontrada...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }

            }
        }
        #endregion
        #region REMOVER
        public void RemoverPerson()
        {
            Console.Clear();
            using (var context = new PersonContext())
            {
                Console.WriteLine("\n>>>Remover Cadastro<<<");
                Console.Write("\nNome: ");
                string name = Console.ReadLine().ToUpper();
                Person find = new PersonContext().Persons.Find(name);
                if (find != null)
                {
                    context.Entry(find).State = EntityState.Deleted;
                    context.Persons.Remove(find);
                    context.SaveChanges();
                    Console.WriteLine("\nCadastro removido com sucesso...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nCadastro Não Encontrado...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
            }
        }
        #endregion

    }
}
