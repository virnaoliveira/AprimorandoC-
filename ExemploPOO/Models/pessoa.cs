using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        /*abstração: pega uma classe e coloca os atributos mais importantes nela e com base nisso
        criei um objeto que poswso manipular livremente*/
        
        public string nome { get; set; }
        public int idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }
    }
}