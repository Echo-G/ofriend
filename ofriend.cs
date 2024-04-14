using System;
using Terraria.ModLoader;

namespace ofriend
{
    public class ofriend : Mod
    {

    }
    public class Power
    {
        public static int NowPower { get; private set; }
        public static int MaxPower { get; } = 4000;

        public static void IncreasePower(int amount)
        {
            NowPower = Math.Min(NowPower + amount, MaxPower);
        }
        public static void ResetPower()
        {
            NowPower = 0;
        }
    }
}