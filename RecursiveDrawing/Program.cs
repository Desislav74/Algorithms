using System;

namespace RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            DrawFigure(n);
        }

        private static void DrawFigure(int row)
        {
            if (row==0)
            {
                return;
            }
            Console.WriteLine(new string ('*', row));

            DrawFigure(row-1);

            Console.WriteLine(new string('#', row));
        }
    }
}
