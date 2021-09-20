using NUnit.Framework;
using System;

namespace CursoTDD_Ej01
{

    [TestFixture]
    public class Tests
    {
        /*
        EJERCICIO:
        Implementar una calculadora que sume
        2 numeros enteros
        */
        [TestCase(16,9,7)]
        [TestCase(25,12,13)]
        [TestCase(100,33,67)]
        
        //[TestCase("",null,null)]
        //[TestCase(50.0,25.5,24.5)]
        
        [Test]
        public void TestSumar(int resultadoEsperado, int numeroA , int numeroB)
        {
            Assert.AreEqual(resultadoEsperado, SumarCalculadora(numeroA, numeroB));


        }

        private int SumarCalculadora(int v1, int v2)
        {
            //TO-DO --> Manejo de Valores Nulos


            int result = v1 + v2;
            return result;
        }
    }
}