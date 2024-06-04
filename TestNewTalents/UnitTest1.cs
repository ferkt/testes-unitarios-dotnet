using System;
using Xunit;
using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "03/06/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData (3, 2, 1)]
        [InlineData (6, 5, 1)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData (1, 2, 2)]
        [InlineData (4, 5, 20)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData (2, 2, 1)]
        [InlineData (40, 5, 8)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
