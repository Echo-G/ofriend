//using Terraria;
//using Terraria.ModLoader;
//using Terraria.ID;
//using Terraria.GameContent.Creative;

//namespace ofriend.Items.Armor
//{
//    [AutoloadEquip(EquipType.Legs)]
//    public class BocchiLeging : ModItem
//    {
//        public override void SetStaticDefaults()
//        {
//            //DisplayName.SetDefault("波奇酱的裙子");
//            //Tooltip.SetDefault("裙子（）");
//            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
//        }
//        public override void SetDefaults()
//        {
//            Item.width = 20; // 宽
//            Item.height = 22; // 高
//            Item.value = Item.sellPrice(gold: 1); // 价值一金
//            Item.rare = ItemRarityID.Pink; // 品质
//            Item.vanity = true;//装扮 no盔甲
//        }
//        public override void AddRecipes()
//        {
//            var recipe = CreateRecipe();
//            recipe.AddIngredient(ItemID.BlackThread);//黑线
//            recipe.AddIngredient(ItemID.Silk, 10);//丝绸*10
//            recipe.AddTile(TileID.WorkBenches);
//            recipe.Register();
//        }
//    }
//}