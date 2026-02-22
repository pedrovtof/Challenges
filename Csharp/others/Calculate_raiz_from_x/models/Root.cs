using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Threading.Tasks;

namespace Calculate_raiz_from_x.models
{
    public class Root
    {
        private Dictionary<int,int> _cousinNumbers { get; set; }
        //2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31.

        private int _indice { get; set; }

        private int _radicando { get; set; }
    
        private int _root { get; set; }

        public Root()
        {
        }

        public Root(int indice, int radicando)
        {

            _cousinNumbers = new Dictionary<int, int>();
            _cousinNumbers.Add(2,0);
            _cousinNumbers.Add(3,0);
            _cousinNumbers.Add(5,0);
            _cousinNumbers.Add(7,0);
            _cousinNumbers.Add(11,0);
            _cousinNumbers.Add(13,0);
            _cousinNumbers.Add(17,0);
            _cousinNumbers.Order();

            _indice = indice;
            _radicando = radicando;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"> Indice </param>
        /// <param name="y"> Radicando </param>
        /// <returns></returns>
        private int RootNumberLoop(int x, int y)
        {
            int CurrentValue = 0;
            int keyLoop = 0;

            while(CurrentValue != 0)
            {
                for (int i = 1; i < x; i ++)
                {
                    try
                    {
                        var counsin =  _cousinNumbers.ElementAt(keyLoop);
                        CurrentValue = y /counsin.Key;
                        _cousinNumbers[counsin.Key] += 1;
                    }
                    catch
                    {
                        Console.WriteLine("Trocando radicando"); 
                        keyLoop +=1;
                        break;
                    }
                }
                
                Console.WriteLine(CurrentValue);
            }
            
            return 1;
        }
       
        public void CalculateRoot()
        {
            RootNumberLoop(_indice, _radicando);

        }

         public void ShowRoot()
        {
            Console.WriteLine($"O valor do indice {_indice} no radicando {_radicando} é {_root}");
        }

    }
}