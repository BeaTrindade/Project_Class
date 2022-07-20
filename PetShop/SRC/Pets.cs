using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.SRC
{
    internal class Pets
    {
        string Tipo { get; set; }
        string Nome { get; set; }
        string Cor { get; set; }
        string Raca { get; set; }
        string Sexo { get; set; }

        public Pets(string tipo, string nome, string cor, string raca, string sexo)
        {
            Tipo = tipo;
            Nome = nome;
            Cor = cor;
            Raca = raca;
            Sexo = sexo;
        }

        public string Dog()
        {
            return $" O cachorro faz Auuu AuAuAuAuuuuu!!!";
        }
        public string Cat()
        {
            return $" O Gatinho faz Meowwwwww!!!!" ;
        }
        public string Fish()
        {
            return $" O Peixinho Gluub-Gluuub!!!";
        }
        public string Bird()
        {
            return $" O Passarinho faz Piu Pipiuuu!!!";
        }

        public override string ToString()
        {
            return $"Animal para adoção: {Tipo} \n" +
                   $"Nome: {Nome} \n" +
                   $"Cor: {Cor} \n" +
                   $"Raça: {Raca} \n" +
                   $"Sexo: {Sexo} \n";
        }
    }
}