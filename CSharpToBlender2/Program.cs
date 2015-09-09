using System;
using System.Windows.Input;
using Plugin;

namespace CSharpToBlender2
{
    class Program
    {
        private static bool nopress = true;

        [STAThread]
        static void Main(string[] args)
        {
            while (true)
            {
                if (Keyboard.IsKeyDown(Key.Escape) && nopress)
                {
                    break;
                }
                if (Keyboard.IsKeyDown(Key.R) && nopress)
                {
                    DummyPlugin.Register();
                    nopress = false;
                }
                else if (!nopress && !Keyboard.IsKeyDown(Key.R))
                    nopress = true;
            }
        }
    }
}
