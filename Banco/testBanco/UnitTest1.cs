using NUnit.Framework;
using banco;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void comprobarSaldo()
        {            
            int cantidad = 100;
            Cuenta c = new Cuenta();
            int saldo = c.getBalance();
            Assert.AreEqual(cantidad, saldo);
        }

        [Test]
        public void comprobarDeposito()
        {
            Cuenta c = new Cuenta();
            c.deposit(100);
            int saldo = c.getBalance();
            Assert.AreEqual(c, saldo);
        }

        [Test]
        public void comprobarRetirada()
        {
            Cuenta c = new Cuenta();
            c.withDraw(10);
            int saldo = c.getBalance();
            Assert.AreEqual(c,saldo);
        }

        [Test]
        public void comprobarDevuelve()
        {
            Cuenta c = new Cuenta();
            string saldo;
            c.saldoActual = 10;
            saldo = c.ToString();
            Assert.AreEqual(c, saldo);
        }
    }
}