// See https://aka.ms/new-console-template for more information
namespace Snake3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine();
            line.Drow();


            Console.ReadLine();
           

        }

       









    }




}