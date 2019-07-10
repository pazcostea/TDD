using NUnit.Framework;
using JuegoVida;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EstaViva1()
        {
            bool estadoActual = false;
            int numCelulas = 1;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);            
            Assert.IsFalse(c, "Está muerta");
        }

        [Test]
        public void EstaViva2()
        {
            bool estadoActual = true;
            int numCelulas = 2;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsTrue(c, "Está viva");
        }

        [Test]
        public void EstaViva3()
        {
            bool estadoActual = true;
            int numCelulas = 3;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsTrue(c, "Está viva");
        }


        [Test]
        public void EstaViva4()
        {
            bool estadoActual = false;
            int numCelulas = 4;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsFalse(c, "Está muerta");
        }

        [Test]
        public void EstaMuerta1()
        {
            bool estadoActual = false;
            int numCelulas = 1;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsFalse(c, "Está muerta");
        }
        [Test]
        public void EstaMuerta2()
        {
            bool estadoActual = false;
            int numCelulas = 1;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsFalse(c, "Está muerta");
        }
        [Test]
        public void EstaMuerta3()
        {
            bool estadoActual = true;
            int numCelulas = 1;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsTrue(c, "Está viva");
        }
        [Test]
        public void EstaMuerta4()
        {
            bool estadoActual = false;
            int numCelulas = 5;
            Juego celulas = new Juego();
            bool c = celulas.sigueViva(estadoActual, numCelulas);
            Assert.IsFalse(c, "Está muerta");
        }
    }
}