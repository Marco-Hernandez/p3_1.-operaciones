using System;

namespace operaciones
{    
	
	class  operaciones
	{
		
	    int valor1=0;
		int valor2=0;
		int resultado=0;
		
		
		public void Datos(){
			
			Console.Write("Valor 1: ");
			valor1= int.Parse(Console.ReadLine());
			Console.Write("Valor 2: ");
			valor2= int.Parse(Console.ReadLine());
			Console.Clear();
       }
		
		public void Suma(){
			Datos();
		    resultado=valor1 + valor2;
		    Console.WriteLine("El resultado de la suma es:");
		    Console.WriteLine("{0} + {1} = {2}", valor1, valor2, resultado );
		}
		public void Resta(){
			Datos();
		    resultado=valor1 - valor2;
			Console.WriteLine("El resultado de la resta es:");
			Console.WriteLine("{0} - {1} = {2}", valor1, valor2, resultado );
		}
		public void Multiplicacion(){
			Datos();
		    resultado=valor1 * valor2;
			Console.WriteLine("El resultado de la multiplicacion es:");
			Console.WriteLine("{0} * {1} = {2}", valor1, valor2, resultado );
		}
		public void Division(){
			Datos();
		    resultado=valor1 / valor2;
			Console.WriteLine("El resultado de la division es:");
			Console.WriteLine("{0} / {1} = {2}", valor1, valor2, resultado );
		}
		public void AreaTriangulo(){
			Datos();
		    resultado=(valor1 * valor2)/2;
			Console.WriteLine("El area del triangulo es:");
			Console.WriteLine("{0} * {1} / 2 = {2}", valor1, valor2, resultado );
		}
		public void AreaCirculo(){
			double pi,area,radio;
			Console.Write("Radio: ");
			radio= double.Parse(Console.ReadLine());
			pi=Convert.ToDouble(3.1416);
			area= pi*(radio * radio);
			
			Console.WriteLine("El area del circulo es:");
			Console.WriteLine(" {0} * {1}^2 = {2}", pi, radio,area);
		}
		public void AreaCuadrado(){
			Datos();
		    resultado=valor1 * valor2;
			Console.WriteLine("El area del cuadrado es:");
			Console.WriteLine(" Lado 1={0} * Lado 2={1} = {2}", valor1, valor2, resultado );
		}
			
	
		
		public static void Main(string[] args)
		{
			operaciones op=new operaciones();
			Console.Title = "Operaciones Practica 1 - Marco Hernandez";
		    int opcion;
			Console.WriteLine(  "1.-Suma\n" +
			                	"2.-Resta\n" +
			                	"3.-Multiplicacion\n" +
			                	"4.-Division\n" +
			                    "5.-Area triangulo\n " +
			                	"6.-Area Circulo\n" +
			                    "7.-Area cuadrado");
			                    
			Console.WriteLine("\nEliga la operacion a realizar:");
			opcion= int.Parse(Console.ReadLine());
        
			switch(opcion){
					case 1:{ 
						op.Suma();
						break;
						}
					case 2:{
						op.Resta();
						break;
						}
					case 3:{ 
						op.Multiplicacion();
						break;
						}
					case 4:{ 
						op.Division();
						break;
						}
					case 5:{
						op.AreaTriangulo();
						break;
						}
					case 6:{
						op.AreaCirculo();
						break;
						}
					case 7:{ 
				        op.AreaCuadrado();
				        
						break;
						}
			
			}	
		}
	}
 }