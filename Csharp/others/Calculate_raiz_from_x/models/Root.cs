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

        private int _indice { get; set; }

        private int _radicando { get; set; }

        private int _origin_radicando { get; set; }
    
        private int _root { get; set; }

        public Root()
        {
            _cousinNumbers = new Dictionary<int, int>();
            _indice = 0;
            _radicando = 0;
        }

        public Root(int indice, int radicando)
        {
            _cousinNumbers = new Dictionary<int, int>();

            _indice = indice;
            _radicando = radicando;
        }

        private int ValidateMdc(List<int> Numbers, int radicando)
        {
            int isValid = -99;

            foreach(var number in Numbers)
            {

                isValid = radicando % number == 0 ?number:-99;

                if(isValid != -99)
                {
                    Console.WriteLine($"Radicando: {radicando} Primo:{number} tem como resto {radicando % number}");
                    break;
                }
             
            }

            return isValid;
        }

        private int ValidateMdc(int indice, int radicando)
        {
            List<int> CounsinNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31];

            int isValid = this.ValidateMdc(CounsinNumbers, radicando);

            if(isValid == -99)
            {
                throw new Exception("Valor não pode ser calculado pelos primos informados");
            }

            return isValid;
        }

        private int RootLoop(int indice, int radicando, int cousin)
        {

            if(!_cousinNumbers.ContainsKey(cousin))
            {
                _cousinNumbers.TryAdd(cousin,0);
            }
            
            int value = _cousinNumbers[cousin];
            _cousinNumbers[cousin] = value + 1;

            int resto = radicando % cousin;
            int division = radicando / cousin;

            Console.WriteLine($"na divisão, contagem do indice para dicionario com Chave em {cousin} foi de valor {value} para {_cousinNumbers[cousin]}, a divisão entre radicando e primo retornou {division}");

            if(resto > 0)
            {
                return -98;
            }

            return division;

        }
   
        private int CalculateTheRootUsingRadicando()
        {

            int root=1;

            Dictionary<int,int> splitIndices = new Dictionary<int,int>();

            foreach(var number in _cousinNumbers)
            {

                int splitByIndice = number.Value / _indice;

                splitIndices.Add(number.Key,splitByIndice);

                Console.WriteLine(
                $"Calculando os valores para multiplicar os MDC, o indice: {_indice} e a chave:{number.Key} com valor:{number.Value} tem como split {splitByIndice}"
                );
                

            }

            List<int> someSplit = new List<int>();

            foreach(var split in splitIndices)
            {
                Power power = new Power(
                    x: split.Key,
                    expoent: split.Value 
                );
                power.CalculatePower();

                int value = power.GetExponentation();
                
                Console.WriteLine($"Executando com split {split} resultado deveria ser potencia dos {value}");

                if(split.Value > 0)
                {
                    someSplit.Add(value);
                }
                
            }
            
            for(int i = 0;i<someSplit.Count();i++)
            {
                Console.WriteLine($"root: {root} multiplicado pelo {someSplit[i]}");
                root = someSplit[i] * root;
            }

            return root;
        }

        public void CalculateRoot()
        {
            Console.WriteLine($"Iniciado calculo de raiz com indice: {_indice} radicando: {_radicando}");
            _origin_radicando = _radicando;

            bool stopLoop = false;
            do{
                int valueForMdc = this.ValidateMdc(_indice,_radicando);
                int newValue = this.RootLoop(_indice, _radicando, valueForMdc);

                if(newValue <= 1)
                {
                    _root = this.CalculateTheRootUsingRadicando();
                    stopLoop = true;
                }
                else
                {
                    _radicando = newValue;
                    continue;
                }
            }
            while(stopLoop == false);
        }

        public bool RealMathValidate()
        {
            Power power = new Power(
                x: _root,
                expoent: _indice 
            );
            power.CalculatePower();

            int value = power.GetExponentation();

            Console.WriteLine($"Tirando prova real, o resultado {_root} elevado ao {_indice} deveria ser igual a {_origin_radicando}");
            
            if(value == _origin_radicando)
            {
                Console.WriteLine($"Prova real confirmada");
                return true;
            }
            else
            {
                Console.WriteLine($"Prova real negada");
                return false;
            }

            
        }

        public void ShowRoot()
        {
            if(_root == -98)
            {
                string content = "\n!!! Raiz não pode ser calculada pois é complexa/fracionada (é um conjunto de raizes) !!!! \n";

                Console.WriteLine(content);
                //throw new Exception(content);
            }

            bool isValid = this.RealMathValidate();

            if (!isValid)
            {
                Console.WriteLine("Ops! fração fracionada");
            }

            Console.WriteLine($"\nRaiz é {_root}\n\n");
        }

    }
}