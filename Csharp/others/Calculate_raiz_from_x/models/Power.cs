using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculate_raiz_from_x.models
{
    public class Power
    {

        private int _x { get; set; }

        private int _Expoent { get; set; }

        private int _Exponentiation { get; set; }

       public Power()
        {
            
        } 

        public Power(int x, int Expoent)
        {
            this._x = x;
            this._Expoent =  Expoent;
        }

        /// <summary>
        /// Para esse desafio foi optado por seguir forcando o calculo manualmente, abaixo está loop de potencia
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private int PowerNumberLoop(int x)
        {
            
            int CurrentNumberOfThePower = x;

            for(int i=1; i < _Expoent; i++)
            {
                CurrentNumberOfThePower = CurrentNumberOfThePower*_x;
            }

            // Inversão de valores em base negativa
            if(_x < 0)
            {
               int isEven = 0;
               
               isEven = CurrentNumberOfThePower % 1;

               CurrentNumberOfThePower = isEven == 0 ? CurrentNumberOfThePower = -CurrentNumberOfThePower : CurrentNumberOfThePower ;

            }

            return CurrentNumberOfThePower;
            
        }


        /// <summary>
        /// Existem algumas regras para potencias,
        /// abaixo estão essas regras e exceções.
        /// Note que expoente NEGATIVOS como 3^-3 não será 27 e sim 1/27
        /// </summary>
        public void CalculatePower()
        {

            // Potencia com expoente negativado
            if(_Expoent<0)
            {
                _Expoent = Math.Abs(_Expoent);
                // perceba que resultado deverá ser fracionado com base invertida, ou seja será X dividido em expoente partes
            }
            // Potencia elevado a 1 é igual a si mesmo potencializado por si (logo a^1 = a)
            if (_Expoent == 1)
            {
                _Exponentiation = _x;
                return;
            }
            
            // Potencia de 0 é igual a 1 sempre
            if (_Expoent == 0)
            {
                _Exponentiation = 1;
                return;
            }
            
            _Exponentiation = this.PowerNumberLoop(_x);
            

            return;
        }

        public void ShowPowerdNumber()
        {
            Console.WriteLine($"\nnumero {_x} a potencia de {_Expoent}  é igual a {_Exponentiation}\n");
        }
    }
}