using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fusee.Uniplug.Translators;

namespace Plugin
{
    public static class DummyPlugin
    {
        public static void Register()
        {
            Console.WriteLine("Resgistring");
        }
    }

    public class Sidepannel : Gui
    {
    }
}
