using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure s = new Stick(15, 5, '*');

            s.Draw();

            System.Threading.Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();

            System.Threading.Thread.Sleep(500);
            s.Move(Direction.LEFT);
            s.Draw();

            System.Threading.Thread.Sleep(5000);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            System.Threading.Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            System.Threading.Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            //Stick stick = new Stick(6, 6, '*');
            //stick.Draw();

            /*Point p2 = new Point()
            {
                x = 4,
                y = 5,
                c = '#'
            };

            p2.Draw();*/

            Console.ReadLine();
        }
    }
}
