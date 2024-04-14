using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ofriend.Items
{
    public class IncreaseHundredPower : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.autoReuse = true;
            Item.value = 10000;
        }
        public override bool CanUseItem(Player player)
        {
            Power.IncreasePower(100);
            return true;
        }
    }
}
