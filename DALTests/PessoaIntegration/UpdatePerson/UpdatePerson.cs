using NUnit.Framework;
using System;

namespace DALTests.PessoaIntegration.UpdatePerson
{
    [TestFixture]
    class UpdatePerson : Base
    {
        private Guid _secret;

        [SetUp]
        public void SetUp()
        {
            _secret = new Guid();
        }

        [Test, Order(3)]
        //[]
        public void UpdatePerson_Valid()
        {
            var pessoaAtualizada = UltimaPessoaAdicionada;

            pessoaAtualizada.Name = _secret.ToString();

            PessoaDAL.Update(UltimaPessoaAdicionada.Id, pessoaAtualizada);

            Assert.That(VerificarUpdate(pessoaAtualizada), Is.True);
        }
    }
}
