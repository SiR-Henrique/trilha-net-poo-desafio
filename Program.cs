using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program

{
    static void Main (string[] args)
    {

        Iphone ip1 = new Iphone("12345678", "Não tenho Iphone", "987654321", 128);

        ip1.InstalarAplicativo("Itune");
        ip1.ReceberLigacao();
        ip1.Ligar();

        Nokia no1 = new Nokia("40028922", "Tijolão", "666000234", 256);

        no1.InstalarAplicativo("Free fire");
        no1.ReceberLigacao();
        no1.Ligar();
    }
}


