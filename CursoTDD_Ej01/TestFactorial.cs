using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD_Ej01
{

    [TestFixture]
    public class TestFactorial
    {
        [Test]
        [TestCase(5,120)]
        [TestCase(6,720)]
        public void FactorialTest(int factorial, int expected)
        {
            Assert.AreEqual(expected, GetFactorial(factorial));
        }

        private int GetFactorial(int v)
        {
            if (v == 0)
                return 1;

            int aux = 1;
            for (int i = v; i >= 1; i--)
            {
                aux *= i;
            }
            return aux;

        }
    }
}
