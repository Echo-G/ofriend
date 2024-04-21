using System;
using Terraria.Audio;
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
        private bool soundPlay;
        public void SoundPowerup()
        {
            if (NowPower == 1000 || NowPower == 2000 || NowPower == 3000)
            {
                SoundStyle soundpowerup = new SoundStyle("ofriend/Assets/Sounds/Powerup");
                SoundEngine.PlaySound(soundpowerup);
            }
            if (NowPower == 4000 && soundPlay == false)
            {
                SoundStyle soundpowerup = new SoundStyle("ofriend/Assets/Sounds/Powerup");
                SoundEngine.PlaySound(soundpowerup);
                soundPlay = true;
            }
        }

        public static void IncreasePower(int amount)
        {
            NowPower = Math.Min(NowPower + amount, MaxPower);
            Power power = new Power();
            power.SoundPowerup();
        }
        public static void ResetPower()
        {
            NowPower = 0;
            Power power = new Power();
            power.soundPlay = false;
        }
    }
}