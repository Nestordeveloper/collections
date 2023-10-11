using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tres matrices básicas
        int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] nombres = { "Tim", "Martin", "Nikki", "Sara" };
        bool[] alternar = new bool[10];

        for (int i = 0; i < 10; i++)
        {
            alternar[i] = i % 2 == 0; // Alternar entre verdadero y falso
        }

        // Lista de Sabores
        List<string> saboresHelado = new List<string> { "Vainilla", "Chocolate", "Frutilla", "Mango", "Menta", "Manjar" };

        Console.WriteLine($"Longitud de la lista de sabores: {saboresHelado.Count}");

        Console.WriteLine($"Tercer sabor de la lista: {saboresHelado[2]}");
        saboresHelado.RemoveAt(2); // Eliminar el tercer sabor

        Console.WriteLine($"Nueva longitud de la lista: {saboresHelado.Count}");

        // Diccionario de Información del Usuario
        Dictionary<string, string> diccionarioUsuarioSabor = new Dictionary<string, string>();

        for (int i = 0; i < nombres.Length; i++)
        {
            string saborAleatorio = ObtenerSaborAleatorio(saboresHelado);
            diccionarioUsuarioSabor.Add(nombres[i], saborAleatorio);
        }

        // Imprimir el diccionario
        Console.WriteLine("Diccionario de Información del Usuario:");
        foreach (var kvp in diccionarioUsuarioSabor)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static string ObtenerSaborAleatorio(List<string> sabores)
    {
        Random rand = new Random();
        int indiceAleatorio = rand.Next(sabores.Count);
        return sabores[indiceAleatorio];
    }
}
