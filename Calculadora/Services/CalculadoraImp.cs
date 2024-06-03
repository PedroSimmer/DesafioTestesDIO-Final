using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{

    public class CalculadoraImp
    {
        private List<string> _listaHistorico;

        public CalculadoraImp()
        {
           _listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            _listaHistorico.Insert(0, "Res: "+ res);
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            _listaHistorico.Insert(0, "Res: "+ res);
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            _listaHistorico.Insert(0, "Res: "+ res);
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero");
            }

            int res = num1/num2; 
            _listaHistorico.Insert(0, "Res: "+ res);
            return res;              

        }

        public bool Ehpar(int num)
        {
            return num % 2 == 0;
        }

        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3,_listaHistorico.Count - 3);
            return _listaHistorico;
        }



    }
}