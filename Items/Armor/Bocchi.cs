//using Terraria;
//using Terraria.ID;
//using Terraria.ModLoader;
//using Terraria.GameContent.Creative;

//namespace ofriend.Items.Armor
//{

//    [AutoloadEquip(EquipType.Head)]
//    public class Bocchi : ModItem
//    {
//        public override void SetStaticDefaults()
//        {
//            //DisplayName.SetDefault("波奇酱的头(?)"); 
//            //Tooltip.SetDefault("派对染发剂你知道在哪吗（）");
//            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;//旅途模式的研究个数
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
//            recipe.AddIngredient(ItemID.PartyHairDye);//派对染发剂
//            recipe.AddIngredient(ItemID.FamiliarWig);//便装假发
//            recipe.AddTile(TileID.WorkBenches);
//            recipe.Register();
//        }
//    }
//}