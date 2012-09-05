// promedio de un numeros dados

using System;
using System.Collections.Generic;

class promedio
{
	public static void Main(string[] args)
	{
		inicio:
		
		Console.Clear();
		Console.ForegroundColor=ConsoleColor.White;
		
		bool salir= true;
		List<double> lista = new List<double>();
		
		
		while(salir)
		{
			
			double contador=0;
			double numero=0;
			
			Console.Clear();
			
			Console.Write("este programa saca el promedio de numeros dados\n\n\n");
			if(lista.Count !=0)
			{
				for(int a=0; a<lista.Count; a++)
				{
					contador += lista[a];
				}
				Console.ForegroundColor= ConsoleColor.Yellow;
				Console.WriteLine("promedio: {0}\n",contador/lista.Count);
				Console.ForegroundColor= ConsoleColor.White;
			}
			
			Console.ForegroundColor= ConsoleColor.Green;
			Console.Write("'s' para salir\n'a' para resetear el contador\n\n");
			Console.ForegroundColor= ConsoleColor.White;
			
			Console.Write("Introdusca opcion o numero: ");
			
			
			string s= Console.ReadLine().ToLower();
			
			if(s == "s")
			{
				salir=false;
				break;
			}
			
			if(s == "a")
			{
				goto inicio;
			}
			
			bool n= double.TryParse(s, out numero);
			
			if(n== true)
			{
				lista.Add(numero);	
			}
			else
			{
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine("El valor debe ser numerico!");
				Console.ForegroundColor=ConsoleColor.White;
				Console.ReadKey();
			}
			
		}
		//Console.ReadKey();
	}
}