﻿
using Calculadora;


Calcula calcu = new Calcula();
int operador, continuar = 1 ; 
double resultado;

do{
  do{
        Console.WriteLine(" 1-SUMA\n 2-RESTA \n 3-MULTIPLICACION\n 4-DIVISION \n 5-LIMPIAR ");
        operador=Convert.ToInt32(Console.ReadLine());

  }while(operador < 1 || operador > 5);

        Console.WriteLine("Ingreser un numero : ");
        calcu.Numero1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingreser un numero : ");
        calcu.Numero2=Convert.ToDouble(Console.ReadLine());


switch(operador){
    case 1 : 
    resultado=calcu.sumar();
    Console.WriteLine($"El resultado es {resultado}");
    break;
    case 2 : 
    resultado=calcu.restar();
    Console.WriteLine($"El resultado es {resultado}");
    break;
    case 3 : 
    resultado=calcu.multiplicar();
    Console.WriteLine($"El resultado es {resultado}");
    break;
    case 4 : 
    if(calcu.Numero2 == 0 ){
         Console.WriteLine("error");
    }else{
    resultado=calcu.dividir();
    Console.WriteLine($"El resultado es {resultado}");
    }
    break;
    default:
    break;
   
}
    calcu.Numero1= calcu.Limpiar();
    calcu.Numero2 = calcu.Limpiar();
    resultado =  calcu.Limpiar();
      

    Console.WriteLine("Seguir usando la calculadoa 1-SI 0-NO");
    continuar=Convert.ToInt32(Console.ReadLine());

    }while(continuar==1);




