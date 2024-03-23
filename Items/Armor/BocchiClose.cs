//using Terraria;
//using Terraria.GameContent.Creative;
//using Terraria.ID;
//using Terraria.ModLoader;

//namespace ofriend.Items.Armor
//{

//	[AutoloadEquip(EquipType.Body)]
//	public class BocchiClose : ModItem
//	{
//		public override void SetStaticDefaults()
//		{
//			//DisplayName.SetDefault("波奇酱的衣服");
//			//Tooltip.SetDefault("卡哇伊");
//			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
//		}
//		public override void SetDefaults()
//		{
//			Item.width = 26; // 宽
//			Item.height = 18; // 高
//			Item.value = Item.sellPrice(gold: 1); // 价值一金
//			Item.rare = ItemRarityID.Pink; // 品质
//			Item.vanity = true;//装扮 no盔甲
//		}
//		public override void AddRecipes()
//		{
//			var recipe = CreateRecipe();
//			recipe.AddIngredient(ItemID.PinkThread);//粉线
//			recipe.AddIngredient(ItemID.Silk, 10);//丝绸*10
//			recipe.AddTile(TileID.Loom);
//			recipe.Register();
//		}
//	}
//}