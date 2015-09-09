using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Fusee.Uniplug.Translators
{
    public class GuiImp : IGui
    {
        public string Translate()
        {
            var properties = GetType().GetProperties().Where(p => p.GetCustomAttributes().Any());

            foreach (var property in properties)
            {
                string bCode = null;
                var bAttrib = new List<string>();

                var attributesInt = property.GetCustomAttributes<GUIIntInput>();
                foreach (var attribute in attributesInt)
                {
                    bCode = "bpy.props.IntProperty(";

                    if (attribute.Name != null)
                    {
                        bAttrib.Add("name=\"" + attribute.Name + "\"");
                    }
                    else
                    {
                        bAttrib.Add("name=\"" + property.Name + "\"");
                    }
                    if (attribute.Default != 0)
                    {
                        bAttrib.Add("default=" + attribute.Default);
                    }
                }

                var attributesFloat = property.GetCustomAttributes<GUIFloatInput>();
                foreach (var attribute in attributesFloat)
                {
                    bCode = "bpy.props.FloatProperty(";

                    if (attribute.Name != null)
                    {
                        bAttrib.Add("name=\"" + attribute.Name + "\"");
                    }
                    else
                    {
                        bAttrib.Add("name=\"" + property.Name + "\"");
                    }
                    if (attribute.Default != 0)
                    {
                        bAttrib.Add("default=" + attribute.Default);
                    }
                }

                bCode += String.Join(", ", bAttrib) + ")";

                if (bCode != null)
                    Console.WriteLine(bCode);
            }

            return null;
        }
    }
}
