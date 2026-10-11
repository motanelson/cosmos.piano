using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;



namespace Cosmosselect
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.Clear();
            int r=400; int c=0; int i=0;
            while (true) 
            
            {
                if (Console.KeyAvailable) 
                {
                    Sys.KeyEvent key = Sys.KeyboardManager.ReadKey();
                    if (key.Key == Sys.ConsoleKeyEx.D0) 
                    {
                        Console.WriteLine("acorde 0");
                        r = 400;
                    
                    }
                    if (key.Key == Sys.ConsoleKeyEx.D1)
                    {
                        Console.WriteLine("acorde 1");
                        r = 500;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D2)
                    {
                        Console.WriteLine("acorde 2");
                        r = 600;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D3)
                    {
                        Console.WriteLine("acorde 3");
                        r = 700;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D4)
                    {
                        Console.WriteLine("acorde 4");
                        r = 800;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D5)
                    {
                        Console.WriteLine("acorde 5");
                        r = 900;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D6)
                    {
                        Console.WriteLine("acorde 6");
                        r = 1000;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D7)
                    {
                        Console.WriteLine("acorde 7");
                        r = 1100;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D8)
                    {
                        Console.WriteLine("acorde 8");
                        r = 1200;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D9)
                    {
                        Console.WriteLine("acorde 9");
                        r = 1300;

                    }
                    if (key.Key == Sys.ConsoleKeyEx.A)
                    {
                        Console.Beep(r+ 0,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.B)
                    {

                        Console.Beep(r + 10,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.C)
                    {

                        Console.Beep(r + 20,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.D)
                    {

                        Console.Beep(r + 30,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.E)
                    {

                        Console.Beep(r + 40,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.F)
                    {

                        Console.Beep(r + 50,250);


                    }
                    if (key.Key == Sys.ConsoleKeyEx.G)
                    {

                        Console.Beep(r + 60,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.H)
                    {

                        Console.Beep(r + 70,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.I)
                    {

                        Console.Beep(r + 80,250);

                    }
                    if (key.Key == Sys.ConsoleKeyEx.J)
                    {

                        Console.Beep(r + 90,250);

                    }
                }
            
            
            
            
            
            }
            
        }
    }
}
