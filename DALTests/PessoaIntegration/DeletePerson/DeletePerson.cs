using DAL.DAL;
using NUnit.Framework;

namespace DALTests.PessoaIntegration.DeletePerson
{
    [TestFixture]
    class DeletePerson : Base
    {
        [Test, Order(4)]
        //[Order(4)]
        public void DeletePessoa_Valid()
        {
            var ultimaPessoaAdicionada = UltimaPessoaAdicionada;

            PessoaDAL.Delete(ultimaPessoaAdicionada.Id);

            Assert.That(VerificarDelete(ultimaPessoaAdicionada), Is.True);
        }
    }
}
