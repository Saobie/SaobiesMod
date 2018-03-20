using Terraria;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Placeable
{
	public class TheMawTrophy : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 1;
			item.createTile = mod.TileType("TheMawTrophyTile");
			item.placeStyle = 0;
		}
	}
}