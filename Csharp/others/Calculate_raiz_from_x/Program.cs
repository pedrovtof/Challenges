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
        Console.Clear();
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
        Console.Clear();
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

