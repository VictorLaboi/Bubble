using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese numeros");
        string input = Console.ReadLine();
        string[] numeros = input.Split(' ');
        int[] num = new int[numeros.Length];
        //El split sirve para quitar espacios del texto que obtuvimos
        for (int i = 0; i < numeros.Length; i++)
        {
            num[i] = int.Parse(numeros[i]);
        } //Recorremos todo el mapa de numeros

        Bubble(num); //Llamamos al metodo local Bubble 

        Console.WriteLine("menor a mayor:");
        foreach (int numb in num)
        {
            Console.Write(numb + " ");
        }

        Console.ReadLine();
    }

    static void Bubble(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}