using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMapFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map.ShowMap();

            Map.ShowMap(2);

            Map.ShowMap(3);

            Map.ShowMap(10);


            Console.ReadKey(true);
        }

        class Map
        {

            static char[,] map = new char[,]
            {
            {'^','^','^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            {'^','^','\'','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\''},
            {'^','^','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\''},
            {'^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            {'\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','\'','\'','\'','\'','\'','\''},
            {'\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\'','\'','\''},
            {'\'','\'','\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\''},
            {'\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
            };

            static int Xlength = map.GetLength(1);
            static int Ylength = map.GetLength(0);
            static char xLine = '═';
            static char yLine = '║';
            static int y;
            static int x;


            static void WriteChar(char c)
            {
                AddColour(c);
                Console.Write(c);
            }

            public static void ShowMap()
            {
                void Border(char edgeA, char edgeB)
                {
                    WriteChar(edgeA);

                    for (int xBorder = 0; xBorder < Xlength; xBorder++)
                    {
                        WriteChar(xLine);
                    }

                    WriteChar(edgeB);
                }

                Border('╔', '╗');
                WriteChar('\n');

                for (y = 0; y < Ylength; y++)
                {
                    WriteChar(yLine);

                    for (x = 0; x < Xlength; x++)
                        WriteChar(map[y, x]);

                    WriteChar(yLine);
                    WriteChar('\n');
                }

                Border('╚', '╝');
                WriteChar('\n');
            }

            public static void ShowMap(int scale)
            {

                void Border(char edgeA, char edgeB)
                {
                    WriteChar(edgeA);

                    for (int xBorder = 0; xBorder < Xlength * scale; xBorder++)
                    {
                        WriteChar(xLine);
                    }

                    WriteChar(edgeB);
                }

                Border('╔', '╗');
                WriteChar('\n');

                for (int y = 0; y < Ylength; y++)
                    for (int i = 0; i < scale; i++)
                    {
                        WriteChar(yLine);

                        for (int x = 0; x < Xlength; x++)
                            for (int j = 0; j < scale; j++)
                                WriteChar(map[y, x]);

                        WriteChar(yLine);
                        WriteChar('\n');
                    }

                Border('╚', '╝');
                WriteChar('\n');
            }

            static void AddColour(char c)
            {
                switch (c)
                {
                    case '^':
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case '*':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case '~':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case '\'':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                }
            }
           
        }
    }
}
