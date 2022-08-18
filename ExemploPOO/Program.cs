using ExemploPOO.Models;

namespace ExemploPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Pessoa p1 = new Pessoa(); //criei o objeto
            p1.nome = "Virna";
            p1.idade = 20;

            p1.Apresentar(); //Método*/

            retangulo r = new retangulo();
            r.definirMedidas(30,30);
            r.obterArea();
            System.Console.WriteLine($"Área: {r.obterArea()}");
        }
    }
}
