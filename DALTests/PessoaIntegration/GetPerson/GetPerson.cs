using NUnit.Framework;

namespace DALTests.PessoaIntegration.GetPerson
{
    [TestFixture]
    class GetPerson : Base
    {
        [Test, Order(2)]
        //[Order(2)]
        public void GetPerson_LastPerson_Valid()
        {
            Assert.That(VerificarGet(UltimaPessoaAdicionada), Is.True);
        }

        [Test]
        [Order(5)]
        public void GetPerson_RandomPerson_Valid()
        {
            Assert.That(VerificarGet(PessoaAleatoria), Is.True);
        }
    }
}
