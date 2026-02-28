// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Calculate_raiz_from_x.models;


do
{
    Console.WriteLine("Hello!\nSe deseja seguir para potencia digite <potencia> se quiser seguir para raiz digite <raiz> e para sair <sair>");

    string option = "";
    option= Console.ReadLine();

    if(option == "potencia")
    {
        Console.WriteLine("Informe a base:");
        int _base = -9999;
        Int32.TryParse(Console.ReadLine(), out _base);

        Console.WriteLine("Informe o expoente:");
        int expoent = -9999;
        Int32.TryParse(Console.ReadLine(), out expoent);


        if(_base == -9999 || expoent == -9999)
        {
            throw new Exception("Necessário passar parametro");
        }

        Power power = new Power(
            x:_base,
            expoent:expoent
        );

        power.CalculatePower();
        power.ShowPowerdNumber();

    }
    else if(option == "raiz")
    {
        Console.WriteLine("Informe a indice:");
        int indice = -9999;
        Int32.TryParse(Console.ReadLine(), out indice);

        Console.WriteLine("Informe o radicando:");
        int radicando = -9999;
        Int32.TryParse(Console.ReadLine(), out radicando);
        

        if(indice == -9999 || indice == -9999)
        {
            throw new Exception("Necessário passar parametro");
        }

        Root root= new Root(
            indice:indice,
            radicando:radicando
        );

        root.CalculateRoot();
        root.ShowRoot();

    }
    else if (option == "sair")
    {
        break;
    }
    else
    {
        Console.WriteLine("Infelizmente não foi possivel seguir sem uma das opçoes marcadas");
    }

}
while(true);



/*
Console.WriteLine("\n\n");
Power power_ = new Power(
    x:,
    Expoent:
);

power_.CalculatePower();
power_.ShowPowerdNumber();


Console.WriteLine("\n\nRaiz ");
Root root_ = new Root(
    indice:,
    radicando:
);

root_.CalculateRoot();
root_.ShowRoot();

*/


/*
Console.WriteLine("\n\npotencia par");
Power power_1 = new Power(
    x:3,
    expoent:2
);


power_1.CalculatePower();
power_1.ShowPowerdNumber();


Console.WriteLine("\n\nTroca de persona => 1\n");
Console.WriteLine("\nRaiz simples ao quadrado");
Root root_1 = new Root(
    indice:2,
    radicando:4
);

root_1.CalculateRoot();
root_1.ShowRoot();
Console.WriteLine("Resultado correto 2");



Console.WriteLine("\n\npotencia impar");
Power power_2 = new Power(
    x:3,
    Expoent:3
);

power_2.CalculatePower();
power_2.ShowPowerdNumber();

Console.WriteLine("\n\npotencia base negativa com expoente par");
Power power_3 = new Power( 
    x:-3,
    Expoent:3
);

power_3.CalculatePower();
power_3.ShowPowerdNumber();


Console.WriteLine("\n\npotencia base negativa com expoente inpar");

Power power_4 = new Power( 
    x:-3,
    Expoent:2
);

power_4.CalculatePower();
power_4.ShowPowerdNumber();

Console.WriteLine("\n\npotencia com Expoente 0");
Power power_5 = new Power(
    x:3,
    Expoent:0
);

power_5.CalculatePower();
power_5.ShowPowerdNumber();

Console.WriteLine("\n\npotencia com Expoente 1");
Power power_6 = new Power(
    x:-3,
    Expoent:1
);


power_6.CalculatePower();
power_6.ShowPowerdNumber();


Console.WriteLine("\n\npotencia com Expoente negativo");
Power power_7 = new Power(
    x:5,
    Expoent:-4
);


power_7.CalculatePower();
power_7.ShowPowerdNumber();



Console.WriteLine("\n\nTroca de persona => 3\n");
Console.WriteLine("\nRaiz simples ao cubo");
Root root_3 = new Root(
    indice:3,
    radicando:27
);

root_3.CalculateRoot();
root_3.ShowRoot();
Console.WriteLine("Resultado correto 3");


Console.WriteLine("\nTroca de persona => 4\n");
Console.WriteLine("\n\nRaiz simples ao quadrado");
Root root_4 = new Root(
    indice:2,
    radicando:625
);

root_4.CalculateRoot();
root_4.ShowRoot();
Console.WriteLine("Resultado correto 25");


Console.WriteLine("\n\nTroca de persona => 5\n");
Console.WriteLine("\nRaiz simples ao quadrado");
Root root_5 = new Root(
    indice:2,
    radicando:36
);


root_5.CalculateRoot();
root_5.ShowRoot();
Console.WriteLine("Resultado correto 6");


Console.WriteLine("\n\nTroca de persona => 6\n");
Console.WriteLine("\nRaiz simples ao quadrado");
Root root_6 = new Root(
    indice:2,
    radicando:42
);


root_6.CalculateRoot();
root_6.ShowRoot();
Console.WriteLine("Resultado correto 6.4");


Console.WriteLine("\n\nTroca de persona => 2\n");
Console.WriteLine("\nRaiz simples ao quadrado");
Root root_2 = new Root(
    indice:2,
    radicando:8
);

root_2.CalculateRoot();
root_2.ShowRoot();
Console.WriteLine("Resultado correto 2.8");

*/