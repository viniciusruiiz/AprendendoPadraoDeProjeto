using DAL.DAL;
using Entidade;

namespace DALTests.PessoaIntegration
{
    public class Base
    {
        #region .: Atributos

        public PessoaDAL PessoaDAL;

        #endregion

        #region .: Construtores

        public Base()
        {
            this.PessoaDAL = new PessoaDAL();
        }

        #endregion

        #region .: Metodos de verificacao

        public bool VerificarInsert(Pessoa novaPessoa)
        {
            var novaPessoaBanco = PessoaDAL.Get(novaPessoa.Id);

            if (novaPessoaBanco is null)
            {
                return false;
            }

            if (novaPessoaBanco.Id != novaPessoa.Id)
            {
                return false;
            }

            if (novaPessoaBanco.Name != novaPessoa.Name)
            {
                return false;
            }

            if (novaPessoaBanco.Email != novaPessoa.Email)
            {
                return false;
            }

            if (novaPessoaBanco.BirthDate.Date != novaPessoa.BirthDate.Date)
            {
                return false;
            }

            return true;
        }

        public bool VerificarGet(Pessoa pessoa)
        {
            var pessoaRetornada = PessoaDAL.Get(pessoa.Id);

            if (pessoaRetornada is null)
            {
                return false;
            }

            if (pessoaRetornada.Id != pessoa.Id)
            {
                return false;
            }

            if (pessoaRetornada.Name != pessoa.Name)
            {
                return false;
            }

            if (pessoaRetornada.Email != pessoa.Email)
            {
                return false;
            }

            if (pessoaRetornada.BirthDate.Date != pessoa.BirthDate.Date)
            {
                return false;
            }

            return true;
        }

        public bool VerificarUpdate(Pessoa pessoa)
        {
            var pessoaAtualizada = PessoaDAL.Get(pessoa.Id);

            if (pessoaAtualizada is null)
            {
                return false;
            }

            if (pessoaAtualizada.Id != pessoa.Id)
            {
                return false;
            }

            if (pessoaAtualizada.Name != pessoa.Name)
            {
                return false;
            }

            if (pessoaAtualizada.Email != pessoa.Email)
            {
                return false;
            }

            if (pessoaAtualizada.BirthDate.Date != pessoa.BirthDate.Date)
            {
                return false;
            }

            return true;
        }

        public bool VerificarDelete(Pessoa pessoa)
        { 
            var pessoaDeletada = PessoaDAL.Get(pessoa.Id);

            if (pessoaDeletada is null)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region .: SQL

        public Pessoa UltimaPessoaAdicionada
        {
            get
            {
                return PessoaDAL.GetLastUser();
            }
        }

        public Pessoa PessoaAleatoria
        {
            get
            {
                return PessoaDAL.GetRandomPessoa();
            }
        }

        #endregion
    }
}
