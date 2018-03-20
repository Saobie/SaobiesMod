using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class LordArmySigil : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Sigil that gives the power to single handedly raise armies. Provides immense summoner boosts."
					+ "\n+3 max minions and sentries. +20% minion damage.");
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
				player.maxMinions += 3;
				player.maxTurrets += 3;
				player.minionDamage += 0.2f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HerculesBeetle, 1);
			recipe.AddIngredient(ItemID.PygmyNecklace, 1);
			recipe.AddIngredient(mod, "LordlyEmblem", 1);
			recipe.AddIngredient(ItemID.MonkBelt, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 50);
			recipe.AddIngredient(ItemID.SquireShield, 1);
			recipe.AddIngredient(ItemID.HuntressBuckler, 1);
			recipe.AddIngredient(ItemID.ApprenticeScarf, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}