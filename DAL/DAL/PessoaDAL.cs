using DAL.Interface;
using DAL.Utils;
using Entidade;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class PessoaDAL : IDataAccessObjectCRUD<Pessoa>
    {
        public Pessoa Get(int id)
        {
            using (ISession session = DatabaseHelper.OpenSession())
            {
                Pessoa pessoa = session.Get<Pessoa>(id);

                return pessoa;
            }
        }

        public void Insert(Pessoa pessoa)
        {
            using (ISession session = DatabaseHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(pessoa);

                transaction.Commit();
            }
        }

        public void Update(int id, Pessoa novaPessoa)
        {
            using (ISession session = DatabaseHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                var pessoa = session.Get<Pessoa>(id);
                
                if(novaPessoa != pessoa)
                {
                    if(novaPessoa.Name != pessoa.Name)
                    {
                        pessoa.Name = novaPessoa.Name;
                    }

                    if (novaPessoa.Email != pessoa.Email)
                    {
                        pessoa.Email = novaPessoa.Email;
                    }

                    if (novaPessoa.BirthDate != pessoa.BirthDate)
                    {
                        pessoa.BirthDate = novaPessoa.BirthDate;
                    }
                }

                session.Update(pessoa);

                transaction.Commit();
            }
        }

        public void Delete(int id)
        {
            using (ISession session = DatabaseHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                Pessoa pessoaParaDeletar = session.Get<Pessoa>(id);

                session.Delete(pessoaParaDeletar);

                transaction.Commit();
            }
        }

        public Pessoa GetLastUser()
        {
            using (ISession session = DatabaseHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                return session.QueryOver<Pessoa>()
                    .OrderBy(c => c.Id)
                    .Desc
                    .Take(1)
                    .SingleOrDefault();
            }
        }

        public Pessoa GetRandomPessoa()
        {
            using (ISession session = DatabaseHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                return session
                    .QueryOver<Pessoa>()
                    .OrderByRandom()
                    .Take(1)
                    .SingleOrDefault();
            }
        }
    }
}
