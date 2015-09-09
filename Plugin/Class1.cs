using System;
using Fusee.Uniplug.Translators;

namespace Plugin
{
    public static class DummyPlugin
    {
        public static void Register()
        {
            Console.WriteLine("Registring");

            var pannel = new Pannel1();
            pannel.Power = 1;
            pannel.Magnitude = 4;

            pannel.Translate();
        }
    }

    public class Pannel1 : Gui
    {
        [GUIIntInput]
        public int Magnitude { get; set; }

        [GUIFloatInput]
        public float Power { get; set; }

        public float Bla { get; set; }
    }
}