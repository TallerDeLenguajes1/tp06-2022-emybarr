using System;

namespace Ejercicio2
{
    public class empleado
    {
        private string nombre ;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil;
        private char genero; 
        private string cargo ;
        private double sueldoBasico;
        private DateTime fechaIngreso;
        private double sueldo ;
        private double adicional;

        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public double Adicional { get => adicional; set => adicional = value; }
        public int Edad { get => edad; set => edad = value; }

        public enum cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public double antiguedad()
         {
         DateTime fechaActual = DateTime.Now;
         TimeSpan antiguedad = fechaActual - FechaIngreso;
         return Convert.ToInt32(antiguedad.TotalDays/365.25);
        }
        
        public int calcularEdad()
        {
            Edad = DateTime.Today.Year - FechaDeNacimiento.Year;

            if (DateTime.Today.Month < FechaDeNacimiento.Month)
            {
                --Edad;                
            }
            else if (DateTime.Today.Month == FechaDeNacimiento.Month && DateTime.Today.Day < FechaDeNacimiento.Day)
            {
                --Edad;
            }

            return Edad;
        }

        public void jubilacion()
    {
            if(Genero == 'F' ){
                if(calcularEdad() < 60){
                     int  jub = 60 - calcularEdad();
                     Console.WriteLine("Años que faltan para jubilarse " + jub);    
                }else{
                     Console.WriteLine("En edad de jubilarse ");
                }
            }else{
                    if(calcularEdad() < 65){
                     int  jub = 65 - calcularEdad();
                     Console.WriteLine("Años que faltan para jubilarse: " + jub);
                }else{
                     Console.WriteLine("En edad de jubilarse ");
                }
            }

        }

         public static empleado crearEmpleado(){
         
            Random rand = new Random();
            empleado nuevoEmpleado = new empleado();
            Console.WriteLine("Ingrese el nombre del empleado : ");
            nuevoEmpleado.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido  del empleado : ");
            nuevoEmpleado.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento dd/mm/aaaa : ");
            nuevoEmpleado.FechaDeNacimiento =  DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese estado civil S-SOLTERO C-CASADO : ");
            nuevoEmpleado.EstadoCivil = Console.ReadLine()[0];
            Console.WriteLine("Ingrese genero F-FEMENINO M-MASCULINO : ");
            nuevoEmpleado.Genero = Console.ReadLine()[0];
             Console.WriteLine("Ingrese fecha de ingreso dd/mm/aaaa : ");
            nuevoEmpleado.FechaIngreso =  DateTime.Parse(Console.ReadLine());
            nuevoEmpleado.SueldoBasico= rand.Next(30000,70000);
            nuevoEmpleado.Cargo = Enum.GetName(typeof(cargos), rand.Next(1, Enum.GetNames(typeof(cargos)).Length));

            return nuevoEmpleado;
        }
       

        public double calcularAdicional(){
            double ant , carg, casado;
            Adicional=0;
            
            if(antiguedad() < 20){
                ant = SueldoBasico * antiguedad()/100;
              
            }else{
                  ant = SueldoBasico * (antiguedad()*0.25);
                   
            }

            if(EstadoCivil == 'C'){
                casado = 1500;
            }else{
                casado = 0;
            }

            if(cargo == "Ingeniero" || cargo =="Especialista"){
                carg = ant * 1.5;
              
            }else{
                carg = 0;
            }
           
         return Adicional =  casado + carg + ant;

        }
        
         public double salario(){
          return Sueldo = SueldoBasico + calcularAdicional() ;
        }


    }
}
