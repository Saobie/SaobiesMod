using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class ArchmageEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Emblem that represents the capacity to learn. Provides great magic bonuses."
					+ "\nUnderstanding comes from chaos. Teach them to understand."
					+ "\n+15% magic damage and crit. -10% mana cost. Improved mana regen. +20 max mana");
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
				player.magicDamage += 0.15f;
				player.magicCrit += 15;
				player.manaRegen += 3;
				player.statManaMax2 += 20;
				player.manaCost -= 0.10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SorcererEmblem, 1);
			recipe.AddIngredient(ItemID.ManaFlower, 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.ManaRegenerationBand, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}