// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{

    /*
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a sua idade:");

        int idade = int.Parse(Console.ReadLine());


        if (idade >= 0 && idade <= 11)
        {
            Console.WriteLine("É uma criança ainda...");
        }
        else
        {
            Console.WriteLine("Hmmm, você não é uma criança");
        }
    }*/
    static void Main(string[] args)
    {
        ExibitMsg();
        GerarPreco(10, 0.2f);
    }

    static void ExibitMsg()
    {
        Console.WriteLine("Esse é um teste");
        
    }

    //testando algumas funções com float
    static void GerarPreco(float preco, float taxa)
    {
        var resultado = preco % taxa + preco;
        Console.WriteLine("Valor com taxa atribuida: " +resultado.ToString("F"));
    }
}



