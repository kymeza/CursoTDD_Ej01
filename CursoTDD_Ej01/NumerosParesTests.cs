using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD_Ej01
{
    [TestFixture]
    public class NumerosParesTests
    {

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void NumerosPares_CheckNumeroPar_TrueSiElValorEsPar()
        {
            NumerosPares numerosPares = new NumerosPares();
            var resultado = numerosPares.CheckNumeroPar(6);

            Assert.IsTrue(resultado);

        }

        [Test]
        public void NumerosPares_nCheckNumeroPar_TrueSiElValorEsImpar()
        {
            NumerosPares numerosPares = new NumerosPares();
            bool resultado = numerosPares.CheckNumeroPar(9);
            Assert.IsTrue(!resultado);

        }

        [Test]
        public void NumerosPares_ObtenerNumerosParesRango_ComprobarRangoValidoDeNumerosPares()
        {
            NumerosPares numerosPares = new NumerosPares();

            List<int> resultadosEsperados = new() { 4, 6, 10, 12, 14 };

            List<int> FakeList = new() { 4, 4, 4, 4, 4 };

            List<int> listaResultados = numerosPares.ObtenerNumerosParesRango(5, 14);

            //Assert.AreEqual(resultadosEsperados, listaResultados);
            //Assert.IsEmpty(listaResultados);
            //Assert.IsNotEmpty(listaResultados);
            //Assert.That(listaResultados.Count, Is.EqualTo(6));
            //Assert.AreEqual(6, listaResultados.Count);
            //Assert.Contains(4, listaResultados);
            //Assert.That(listaResultados, Is.Ordered);
            //Assert.That(listaResultados, Is.Ordered.Descending);
            Assert.That(FakeList, Is.Unique);

        }

    }
}
