using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ofriend.Items
{
    public class KoishiFumo:ModItem
    {
        public override void SetDefaults()
        {
            // Vanilla has many useful methods like these, use them! This substitutes setting Item.createTile and Item.placeStyle aswell as setting a few values that are common across all placeable items
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.KoishiFumoTile>());
            Item.width = 18;
            Item.height = 19;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(0, 1);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SummerHat);
            recipe.AddIngredient(ItemID.GreenThread);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
