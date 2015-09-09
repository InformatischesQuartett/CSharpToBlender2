using System;

namespace Fusee.Uniplug.Translators
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GUISidePanel : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class GUIIntInput : Attribute
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Default { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class GUIFloatInput : Attribute
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public float Default { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
    }
}
