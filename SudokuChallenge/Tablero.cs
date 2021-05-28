using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuChallenge
{
    class Tablero
    {
        int[,] tablero = new int[9, 9];
        Random r = new Random();
        //llenamos matriz 9*9 completa en 0
        public void llenarTablero()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tablero[i, j] = 0;
                }
            }
        }
        //introducimos 30 números entre el 1 y 9 aleatorios en pocisiones aleatorias del arreglo
        public void llenadoAleatorio()
        {
            int numAleatorios = 30;
            for (int i=0;i<=numAleatorios;i++)
            {
                int x = r.Next(1,9);
                int y = r.Next(1, 9);
                int valor= r.Next(1, 9);
                tablero[x, y] = valor;
            }
        }
        /*
         *Comparamos si en la posición actual existe una casilla vacia y si esta coincide con el valor dado
         *y verificamos que no se repite en la fila y la columna
         */
        bool valorRepetido(int[,] tabla,int i,int j, int valor)
        {
            for (int x=0;x<9;x++)
            {
                if (tabla[x, j]!=0 && tabla[x,j]==valor)
                {
                    Console.Write("|col" + valor+ "|");
                    return false;
                }
                if (tablero[i, x]!=0 && tabla[i,x]==valor)
                {
                    Console.Write("|fil" +valor+ "|");
                    return false;
                }
            }
            return true;
        }
        /*Recorremos la matriz completa y si la casilla es una que esta vacia hacemos comparaciones de valores entre el 
         * 1 y 9, verificamos que el número insertado no sea repetido y de ser así asugnamos el valor a la casilla
         * aplicamos recursividad repitiendo el proceso hasta que la tabla salga del bucle al estar correcta.
         */
        public bool resolver(int[,] tabla)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tabla[i, j] == 0)
                    {
                        for(int a = 1; a <= 9; a++)
                        {
                            if (valorRepetido(tabla, i, j, a))
                            {
                                tabla[i, j] = a;
                                if (resolver(tabla))
                                {
                                    tablero = tabla;
                                    Console.Write("|a" + a + "|");
                                    return true;
                                }
                                else
                                {
                                    tabla[i, j] = 0;
                                }
                                {

                                }
                            }
                        }
                        return false;
                    }
                }
            }
            tablero = tabla;
            return true;
        }
        //convocamos métodos y pasamos la tabla resuelta
        public int[,] mostrarTabla()
        {
            llenarTablero();
            llenadoAleatorio();
            if (!resolver(tablero))
                return tablero;
            return tablero;
        }
    }
}
