using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class retangulo
    {
        private double comprimento {get; set;} //propriedades privadas só podem ser modificadas nessa classe
        private double largura {get; set;}
        private bool valido {get; set;}

        public void definirMedidas(double comprimento, double largura){
            if(comprimento>0 && largura>0){ 
                this.comprimento = comprimento;
                this.largura = largura; 
                valido = true;
            } else {
                System.Console.WriteLine("Valores inválidos");
            }

        }

        public double obterArea(){
            if(valido){
              return comprimento*largura;  
            } else {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }

    }
}