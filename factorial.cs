// factorial de un numero dado

using System;

class factorial
{
	public static void Main(string[] args)
	{
		Console.Clear();
		Console.ForegroundColor=ConsoleColor.White;
		
		bool salir= true;
		
		while(salir)
		{
		
			double n1=0;
			double contador=1;
			
			Console.Clear();
			
			Console.Write("este programa saca el factorial de un numero\n\n\n");
			Console.Write("introdusca un numero o 's' para salir: ");
			
			string s= Console.ReadLine().ToLower();
			
			if(s == "s")
			{
				salir=false;
				break;
			}
			
			bool n= double.TryParse(s, out n1);
			
			if(n== true && n1>-1)
			{
				while(n1>0)
				{
					contador*= n1;
					n1-=1;
				}
				Console.ForegroundColor=ConsoleColor.Green;
				Console.WriteLine("el factorial es: {0}",contador);
				Console.ForegroundColor=ConsoleColor.White;
				Console.ReadKey();
			}
			else
			{
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine("el valor debe ser numerico y positivo!");
				Console.ForegroundColor=ConsoleColor.White;
				Console.ReadKey();
			}
			
			
		}
		//Console.ReadKey();
	}
}