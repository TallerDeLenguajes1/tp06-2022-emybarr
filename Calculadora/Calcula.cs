using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calcula
    {
        private double numero1;
        private double numero2;
        

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
      

    public double sumar()
    {
    return Numero1 + Numero2 ; 
    }
    
    public double restar()
    {
        return  Numero1 - Numero2 ; 
    }

    public double multiplicar()
    {
        return Numero1 * Numero2;
    }

    public double dividir()
    {
        return Numero1 / Numero2;
        
    }

    public int  Limpiar()
    {
        return 0;

    }
}
}
