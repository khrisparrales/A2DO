/*
 * Created by SharpDevelop.
 * User: khris
 * Date: 03/02/2021
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace A2DO
{
	class Program
	{
		public static void Main(string[] args)
		{
			            int[,] matrizejer1 = new int[10, 10];
            int mayor = matrizejer1[0, 0];
            int [] posicion = new int[10];
            Random genaleatorio = new Random();
            for (int ifil = 0; ifil <= matrizejer1.GetUpperBound(0); ifil++)
            {
                mayor = 0;
                for (int jcol = 0; jcol <= matrizejer1.GetUpperBound(1); jcol++)
                {
                    
                    Console.SetCursorPosition(jcol * 5, (ifil + 1) * 2); matrizejer1[ifil, jcol] = genaleatorio.Next(1, 11);
                    if(mayor < matrizejer1[ifil,jcol])
                    {
                        
                        mayor = matrizejer1[ifil, jcol];
                        posicion[ifil]=jcol;
                    }

                    Console.SetCursorPosition(70, (2 + ifil) * 2); Console.WriteLine(mayor + "      posi:  " + posicion[ifil]);
                }
            }
            //Console.SetCursorPosition(70, 25); Console.WriteLine(matrizejer1[1,1]);
            for (int ifil = 0; ifil <= matrizejer1.GetUpperBound(0); ifil++)
            {
                for (int jcol = 0; jcol <= matrizejer1.GetUpperBound(1); jcol++)
                {
                    Console.SetCursorPosition((jcol + 3) * 5, (ifil + 2) * 2); Console.Write(matrizejer1[ifil, jcol]);
                }
            }
            Console.ReadKey();

		}
	}
}