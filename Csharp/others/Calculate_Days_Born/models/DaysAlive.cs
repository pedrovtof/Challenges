
namespace Calculate_Days_Born.models
{
    internal class DaysAlive
    {
        private int YearBorn { get; set; }

        private int MonthBorn { get; set; }

        private int DayBorn { get; set; }

        private int YearCurr { get; set; }

        private int MonthCurr { get; set; }

        private int DayCurr { get; set; }

        static readonly int DaysPerYear = 365;

        static readonly int MonthPerYear = 12;

        static readonly int DaysPerMonth = 30;


        public DaysAlive() { }

        public DaysAlive(int y_born, int m_born, int d_born, int y_curr, int m_curr, int d_curr)
        {
            YearBorn = y_born;
            MonthBorn = m_born;
            DayBorn = d_born;

            YearCurr = y_curr;
            MonthCurr = m_curr;
            DayCurr = d_curr;
        }

        /// <summary>
        /// Entry point for the class
        /// </summary>
        public void StartProgramCurrentDaysAlive()
        {
            Console.WriteLine($"""
            
                Born in: {YearBorn}/{MonthBorn}/{DayBorn}

                Now is:  {YearCurr}/{MonthCurr}/{DayCurr}
                
                """);

            this.CalculateDaysAlive();

        }

        /// <summary>
        /// Para calcular quantos dias esta vivo.
        /// Importante, como iremos nos limitar a não usar bibliotecas, sem loops e condicionais,
        /// será necessário considerar valores fixos para dias do mes (30) e dias fixos para um ano 365
        /// 
        /// Para conta, será necessário converter grandezas, 
        /// Exemplo: 
        /// não podemos somar um Infinito de 0-1 com um Infito de 0-2.
        /// Porem somar infinitos de mesma grandezas, 0-1 com 0-1  portanto 0-1^2 é sim possível.
        /// É possível dizer que 0-1 é igual a 0-2/2 logo 0-1^2 é igual a 0-1 + (0-2/2)
        /// 
        /// Aqui logica se permanece, assim como Metros não pode ser adicionados a Centimetros e Terabytes em MegaBytes
        /// 
        /// Portanto ao longo do exercisio sempre deixaremos na mesma casa decimal os valores
        /// ANO precisam se transformar em dias
        /// MESES precisam se transformar em dias
        /// 
        /// um ano equivale a 365 dias ou 366
        /// um mes equivale a 28,29,30 ou 31 dias
        /// um dia equivale a 1 ou 1.54 dias
        /// 
        /// aqui temos um problemão, um dia não tem somente 1 dia, um dia poderá ter 1.54 dias em alguns casos,
        /// por isso existe ano com um dia a mais, iremos desconsiderar ok? (assim como 3,14 não é PI e 10 não é a aceleração da gravidade)
        /// Para um calculo mais preciso, deveriamos ir até ao menos a casa de segundos, mão isso não será necessário.
        /// 
        /// </summary>
        private void CalculateDaysAlive()
        {
            int _daysAlive = 0;

            int yearBornToDay = YearsToDay(YearBorn);
            int yearCurrToDay = YearsToDay(YearCurr);

            Console.WriteLine($"Conversão de anos = {yearBornToDay} | {yearCurrToDay}");

            _daysAlive = yearCurrToDay - yearBornToDay;

            int monthBornToDay = MonthToDays(MonthBorn);
            int monthCurrToDay = MonthToDays(MonthCurr);

            Console.WriteLine($"Conversão de meses = {MonthBorn} | {MonthCurr}");

            _daysAlive = _daysAlive + (monthCurrToDay - monthBornToDay);

            Console.WriteLine($"Amostra de dias = {DayBorn} | {DayCurr}");

            _daysAlive = _daysAlive + (DayBorn - DayCurr);

            Console.WriteLine("===+===");

            Console.WriteLine($"""
            Resultado arredondado: {_daysAlive} +-~
            """);

            Console.WriteLine("===+===");
        }

        /// <summary>
        /// Convert year to days
        /// </summary>
        /// <param name="x">INT years</param>
        /// <returns>Amount of the days</returns>
        private int YearsToDay(int x)
        {
            return x * DaysPerYear;
        }

        /// <summary>
        /// Convert Month to Days
        /// </summary>
        /// <param name="x">INT month</param>
        /// <returns>Convert month in days, but considering only 30 days per month</returns>
        private int MonthToDays(int x)
        {
            return x * DaysPerMonth;
        }


    }
}

