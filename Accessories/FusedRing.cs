using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class FusedRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ring made from fusing various other rings in a magical process."
					+ "\nLooks like tungsten, but it cant be..."
					+ "\nImproves mining speed and provides light"
					+ "\nHighlights nearby treasure and dangers");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 3;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(BuffID.Spelunker, 2);
			player.AddBuff(BuffID.Dangersense, 2);
			player.AddBuff(BuffID.Hunter, 2);
			player.AddBuff(BuffID.Shine, 2);
			player.AddBuff(BuffID.Mining, 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.Amethyst, 5);
			recipe.AddIngredient(ItemID.Sapphire, 5);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(mod, "MinerRing", 1);
			recipe.AddIngredient(mod, "SpelunkerRing", 1);
			recipe.AddIngredient(mod, "SurvivorRing", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}