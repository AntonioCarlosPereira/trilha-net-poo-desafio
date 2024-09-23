using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias das classes Nokia e Iphone
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", 16, "111222333444555");
        Smartphone iphone = new Iphone("987654321", "iPhone 13", 128, "555444333222111");

        // Testando os métodos das classes Nokia e Iphone
        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
