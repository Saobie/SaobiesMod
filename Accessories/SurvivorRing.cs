using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class SurvivorRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Special ring made from silver and sapphire."
					+ "\nHighlights nearby traps and enemies");
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
			player.AddBuff(BuffID.Dangersense, 2);
			player.AddBuff(BuffID.Hunter, 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 12);
			recipe.AddIngredient(ItemID.Sapphire, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.HunterPotion, 1);
			recipe.AddIngredient(ItemID.TrapsightPotion, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}