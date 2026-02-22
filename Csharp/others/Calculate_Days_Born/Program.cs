using Calculate_Days_Born.models;

Console.WriteLine("Hello!\nLets do it");

Console.WriteLine("\n\nPERSONA 1 => \n\n");

DaysAlive persona_1 = new DaysAlive(
    y_born: 2003, // Ano nascimento
    m_born: 1, // mes nascimento
    d_born: 21, // dia nascimento
    y_curr: 2026, // ano atual
    m_curr: 2, // mes atual
    d_curr: 16 // dia atual
);

persona_1.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 8428"); // 100,02 errado

Console.WriteLine("\n\nPERSONA 2 => \n\n");

DaysAlive persona_2 = new DaysAlive(
    y_born: 1997, // Ano nascimento
    m_born: 4, // mes nascimento
    d_born: 30, // dia nascimento
    y_curr: 2026, // ano atual
    m_curr: 2, // mes atual
    d_curr: 16 // dia atual
);

persona_2.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 10520"); //99,82 errado

Console.WriteLine("\n\nPERSONA 3 => \n\n");

DaysAlive persona_3 = new DaysAlive(
    y_born: 1956, // Ano nascimento
    m_born: 2, // mes nascimento
    d_born: 29, // dia nascimento
    y_curr: 2026, // ano atual
    m_curr: 2, // mes atual
    d_curr: 16 // dia atual
);

persona_3.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 25556"); // 100,03



Console.WriteLine("\n\nPERSONA 4 => \n\n");


DaysAlive persona_4 = new DaysAlive(
    y_born: 2010, // Ano nascimento
    m_born: 12, // mes nascimento
    d_born: 20, // dia nascimento
    y_curr: 2026, // ano atual
    m_curr: 2, // mes atual
    d_curr: 16 // dia atual
);

persona_4.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 5538"); // 100,11



Console.WriteLine("\n\nPERSONA 5 => \n\n");


DaysAlive persona_5 = new DaysAlive(
    y_born: 2026, // Ano nascimento
    m_born: 2, // mes nascimento
    d_born: 16, // dia nascimento
    y_curr: 2026, // ano atual
    m_curr: 2, // mes atual
    d_curr: 16 // dia atual
);

persona_5.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 0"); // 100




Console.WriteLine("\n\nPERSONA 6 => \n\n");


DaysAlive persona_6 = new DaysAlive(
    y_born: 2026, // Ano nascimento
    m_born: 2, // mes nascimento
    d_born: 16, // dia nascimento
    y_curr: 2077, // ano atual
    m_curr: 7, // mes atual
    d_curr: 14 // dia atual
);

persona_6.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 18789"); // 99,88




Console.WriteLine("\n\nPERSONA 7 => \n\n");


DaysAlive persona_7 = new DaysAlive(
    y_born: 2026, // Ano nascimento
    m_born: 7, // mes nascimento
    d_born: 25, // dia nascimento
    y_curr: 2077, // ano atual
    m_curr: 7, // mes atual
    d_curr: 14 // dia atual
);

persona_7.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 18617"); // 100,05



Console.WriteLine("\n\nPERSONA 8 => \n\n");



Console.WriteLine(DateTime.Today.Subtract(new DateTime(1997, 1, 31)).TotalDays); // -12,75


DaysAlive persona_8 = new DaysAlive(
    y_born: 2077, // Ano nascimento
    m_born: 7, // mes nascimento
    d_born: 25, // dia nascimento
    y_curr: 2077, // ano atual
    m_curr: 7, // mes atual
    d_curr: 14 // dia atual
);

persona_8.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => -11"); // 100


Console.WriteLine("\n\nPERSONA 9 => \n\n");


DaysAlive persona_9 = new DaysAlive(
    y_born: 2077, // Ano nascimento
    m_born: 7, // mes nascimento
    d_born: 25, // dia nascimento
    y_curr: 2077, // ano atual
    m_curr: 8, // mes atual
    d_curr: 25 // dia atual
);

persona_9.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 31"); // 103,33


Console.WriteLine("\n\nPERSONA 10 => \n\n");


DaysAlive persona_10 = new DaysAlive(
    y_born: 2077, // Ano nascimento
    m_born: 8, // mes nascimento
    d_born: 25, // dia nascimento
    y_curr: 2078, // ano atual
    m_curr: 8, // mes atual
    d_curr: 25 // dia atual
);

persona_10.StartProgramCurrentDaysAlive();
Console.WriteLine("resposta correta => 365"); // 100