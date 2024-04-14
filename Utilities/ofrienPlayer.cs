using ofriend.Items.Armor;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ofriend.Utilities
{
    public class ofriendPlayer : ModPlayer
    {
        public bool classicHide;
        public bool classicForce;
        public bool classicPrevious;
        public bool classicPower;
        public bool classicTrans;
        public override void ResetEffects()
        {
            classicTrans = classicHide = classicForce = classicPower = false;
        }
        public override void UpdateVisibleVanityAccessories()
        {
            for (int n = 13; n < 18 + Player.extraAccessorySlots; n++)
            {
                Item item = Player.armor[n];
                if (item.type == ItemType<Boki>())
                {
                    classicHide = false;
                    classicForce = true;
                }
            }
        }
        public override void FrameEffects()
        {
            if ((classicTrans || classicForce) && !classicHide)
            {
                var costume = GetInstance<Boki>();
                Player.head = EquipLoader.GetEquipSlot(Mod, "Boki", EquipType.Head);
                Player.body = EquipLoader.GetEquipSlot(Mod, "Boki", EquipType.Body);
                Player.legs = EquipLoader.GetEquipSlot(Mod, "Boki", EquipType.Legs);
            }
        }
        public override void OnEnterWorld()
        {
            UI.ofriendUI.Visible = true;
            base.OnEnterWorld();
        }
    }
}
