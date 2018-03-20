using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class LordlyEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Emblem that represents the will to move masses. Provides great summoner bonuses."
					+ "\nAll good rulers have a loyal army."
					+ "\n+2 max minions. +10% minion damage.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 8;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.maxMinions += 2;
				player.minionDamage += 0.1f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SummonerEmblem, 1);
			recipe.AddIngredient(ItemID.NecromanticScroll, 1);
			recipe.AddIngredient(ItemID.PygmyNecklace, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}