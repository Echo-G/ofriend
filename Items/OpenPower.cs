using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ofriend.Items
{
    public class OpenPower : ModItem
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
            UI.ofriendUI.Visible = !UI.ofriendUI.Visible;
            return true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Glass);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
