// See https://aka.ms/new-console-template for more information
namespace Snake3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0,24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Point p = new Point(4, 5, '*');
            //HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            //line.Drow();
            //VerticalLine lineV = new VerticalLine(9, 6, 15, '$');
            //lineV.Drow();



            Console.ReadLine();
           

        }

       









    }




}