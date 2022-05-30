using System;
using static Ejercicio2.empleado;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
               empleado[] empleado1 = new empleado[2] ;
            

         for(int i= 0; i < 2; i++){
           
            empleado1[i]= crearEmpleado();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Nombre : {empleado1[i].Nombre}");
            Console.WriteLine($"Apellido : {empleado1[i].Apellido}");
            Console.WriteLine($"Fecha de Nacimieto : {empleado1[i].FechaDeNacimiento}");
            Console.WriteLine($"Edad : {empleado1[i].calcularEdad()}");
            Console.WriteLine($"Estado Civil : {empleado1[i].EstadoCivil}");
            Console.WriteLine($"Genero : {empleado1[i].Genero}");
            Console.WriteLine($"Fecha de Ingreso : {empleado1[i].FechaIngreso}");
            Console.WriteLine($"Sueldo Basico  : {empleado1[i].SueldoBasico}");
            Console.WriteLine($"Cargo  : {empleado1[i].Cargo}");
            Console.WriteLine("Antiguedad " + empleado1[i].antiguedad());
            empleado1[i].jubilacion();
            Console.WriteLine("Sueldo "  + empleado1[i].salario() );
            Console.WriteLine("---------------------------------------------------");
        
        }
          double monto=0;
        foreach( empleado emp in empleado1){
           monto += emp.Sueldo;
        }
         Console.WriteLine($"El monto total de salario es { monto}");
         Console.WriteLine("---------------------------------------------------");
        
         foreach(empleado emp in empleado1){
             if(emp.Edad >= 57 && emp.Edad <= 64){
                 Console.WriteLine($"Nombre : {emp.Nombre}");
                 Console.WriteLine($"Apellido : {emp.Apellido}");
                 Console.WriteLine($"Antiguedad : {emp.antiguedad()}");
                 emp.jubilacion();
                 Console.WriteLine("---------------------------------------------------");

             }
         }

        }

    }
}
    