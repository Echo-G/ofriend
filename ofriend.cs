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

        public static void PlayPowerupSound()
        {
            SoundStyle soundpowerup = new SoundStyle("ofriend/Assets/Sounds/Powerup");
            SoundEngine.PlaySound(soundpowerup);
        }

        public static void IncreasePower(int amount)
        {
            int previousPower = NowPower;
            NowPower = Math.Min(NowPower + amount, MaxPower);

            // 检查NowPower是否跨过了1000、2000、3000或4000的阈值
            if ((previousPower < 1000 && NowPower >= 1000) ||
                (previousPower < 2000 && NowPower >= 2000) ||
                (previousPower < 3000 && NowPower >= 3000) ||
                (previousPower < MaxPower && NowPower >= MaxPower))
            {
                PlayPowerupSound();
            }
        }

        public static void ResetPower()
        {
            NowPower = 0;
        }
    }
}