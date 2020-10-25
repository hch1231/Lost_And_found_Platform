using System;
using System.Collections.Generic;
using System.Text;


namespace LostAndFoundDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Init();
            menu.start();
        }
    }
}
