using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int x, int y) // => x + y;
        {
            int calculo = x + y;
            listaHistorico.Insert(0, RetornaTextoHistorico(calculo, data));
            return calculo;
        }
        public int Subtrair(int x, int y) // => x - y;
        {
            int calculo = x - y;
            listaHistorico.Insert(0, RetornaTextoHistorico(calculo, data));
            return calculo;
        }
        public int Multiplicar(int x, int y) // => x * y
        {
            int calculo = x * y;
            listaHistorico.Insert(0, RetornaTextoHistorico(calculo, data));
            return calculo;
        }
        public int Dividir(int x, int y) // => x / y;
        {
            int calculo = x / y;
            listaHistorico.Insert(0, RetornaTextoHistorico(calculo, data));
            return calculo;
        }
        public string RetornaTextoHistorico(int calculo, string data) // => x / y;
        {
            return "Resultado: " + calculo + " - data: " + data;
        }

        public List<string> Historico() // => new List<string>();
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3); // Remove a partir do 3 a quantidade total menos 3
            return listaHistorico;
        }
    }
}
