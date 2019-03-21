using Entidade;
using NUnit.Framework;
using System;

namespace DALTests.PessoaIntegration.InsertPerson
{
    [TestFixture]
    class InsertPerson : Base
    {
        private Pessoa pessoa;

        [SetUp]
        public void SetUp()
        {
            pessoa = new Pessoa
            {
                Id = new Random().Next(1000000000, 2100000000),
                Name = new Guid().ToString(),
                Email = new Guid().ToString(),
                Password = new Guid().ToString(),
                BirthDate = DateTime.Now.AddYears(-5)
            };
        }

        [Test, Order(1)]
        //[Order(1)]
        public void InsertPerson_Valid()
        {
            PessoaDAL.Insert(pessoa);

            Assert.That(VerificarInsert(pessoa), Is.True);
        }
    }
}
