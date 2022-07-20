using System;
using PetShop.SRC;


namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pets Gato = new Pets("Gato", "Felix", "Preto", "Angorá", "Macho");
            Pets Cachorro = new Pets("Cachorro", "Spike", "Cinza", "Buldogue", "Macho");
            Pets Peixe = new Pets("Peixe", "Cleo", "Laranja", "Dourado", "Fêmea");
            Pets Passaro = new Pets("Passarinho", "Zé", "Verde", "papagaio", "Macho");

            Console.WriteLine("---------------------------");
            Console.WriteLine("---> Pets para Adoção <--- ");
            Console.WriteLine("---------------------------");
            Console.WriteLine(Gato.ToString());
            Console.WriteLine("---------------------------");
            Console.WriteLine(Cachorro.ToString());
            Console.WriteLine("---------------------------");
            Console.WriteLine(Peixe.ToString());
            Console.WriteLine("---------------------------");
            Console.WriteLine(Passaro.ToString());
            Console.WriteLine("---------------------------");

            Console.WriteLine(Gato.Cat());
            Console.WriteLine(Cachorro.Dog());
            Console.WriteLine(Peixe.Fish());
            Console.WriteLine(Passaro.Bird());
            Console.WriteLine("--------------------------");

        }
    }
}