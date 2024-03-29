﻿using System;

namespace pz_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,]
        {
                {0, 1, 1, 0, 0},
                {0, 0, 0, 1, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 1, 0}
        };
            Graph graph = new Graph(a);

            // проверяем связность графа
            bool isConnected = graph.IsConnected();
            Console.WriteLine("Граф является связным: " + isConnected);
            Console.ReadLine();
        }
    }
}
