using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero t1 = new Tablero();
            int[,] tablero1 = new int[9, 9];
            Tablero t2 = new Tablero();
            int[,] tablero2 = new int[9, 9];
            Tablero t3 = new Tablero();
            int[,] tablero3 = new int[9, 9];
            Tablero t4 = new Tablero();
            int[,] tablero4 = new int[9, 9];
            Tablero t5 = new Tablero();
            int[,] tablero5 = new int[9, 9];

            tablero1 = t1.mostrarTabla();
            tablero2 = t2.mostrarTabla();
            tablero3 = t3.mostrarTabla();
            tablero4 = t4.mostrarTabla();
            tablero5 = t5.mostrarTabla();

            imprimirTabla(tablero1);
            imprimirTabla(tablero2);
            imprimirTabla(tablero3);
            imprimirTabla(tablero4);
            imprimirTabla(tablero5);

            void imprimirTabla(int[,] tabla)
            {
                for (int i = 0; i <= 8; i++)
                {
                    for (int j = 0; j <= 8; j++)
                    {
                        Console.Write("|" + tabla[i, j] + "|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
