using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ofriend
{
    public class Ofriendconfig : ModConfig
    {
        private static class Date
        {
            public static float PowerUI_X;
            internal const float PowerUI_X_MinValue=0f;
            internal const float PowerUI_X_MaxValue =500f;
            public static float PowerUI_Y;
            internal const float PowerUI_Y_MinValue = 0f;
            internal const float PowerUI_Y_MaxValue = 500f;
        }
        // ConfigScope.ClientSide should be used for client side, usually visual or audio tweaks.
        // ConfigScope.ServerSide should be used for basically everything else, including disabling items or changing NPC behaviors
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("PowerUI_X")] // Headers are like titles in a config. You only need to declare a header on the item it should appear over, not every item in the category. 
        [LabelArgs("$Config.PowerUI_X")] // A label is the text displayed next to the option. This should usually be a short description of what it does. By default all ModConfig fields and properties have an automatic label translation key, but modders can specify a specific translation key.
        [TooltipArgs("$Config.PowerUI_X")] // A tooltip is a description showed when you hover your mouse over the option. It can be used as a more in-depth explanation of the option. Like with Label, a specific key can be provided.
        [Range(Date.PowerUI_X_MinValue, Date.PowerUI_X_MaxValue)]
        public float PowerUI_X_Value
        {
            get
            {
                if (Date.PowerUI_X < Date.PowerUI_X_MinValue)
                {
                    Date.PowerUI_X = Date.PowerUI_X_MinValue;
                }
                if (Date.PowerUI_X > Date.PowerUI_X_MaxValue)
                {
                    Date.PowerUI_X = Date.PowerUI_X_MaxValue;
                }
                return Date.PowerUI_X;
            }
            set => Date.PowerUI_X = value;
        }
        [Header("PowerUI_Y")] // Headers are like titles in a config. You only need to declare a header on the item it should appear over, not every item in the category. 
        [LabelArgs("$Config.PowerUI_Y")] // A label is the text displayed next to the option. This should usually be a short description of what it does. By default all ModConfig fields and properties have an automatic label translation key, but modders can specify a specific translation key.
        [TooltipArgs("$Config.PowerUI_Y")] // A tooltip is a description showed when you hover your mouse over the option. It can be used as a more in-depth explanation of the option. Like with Label, a specific key can be provided.
        [Range(Date.PowerUI_Y_MinValue, Date.PowerUI_Y_MaxValue)]
        public float PowerUI_Y_Value
        {
            get
            {
                if (Date.PowerUI_Y < Date.PowerUI_Y_MinValue)
                {
                    Date.PowerUI_Y = Date.PowerUI_Y_MinValue;
                }
                if (Date.PowerUI_Y > Date.PowerUI_Y_MaxValue)
                {
                    Date.PowerUI_Y = Date.PowerUI_Y_MaxValue;
                }
                return Date.PowerUI_Y;
            }
            set => Date.PowerUI_Y = value;
        }
    } 
}
