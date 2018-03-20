using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class MinerRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Special ring made from copper and amethyst."
					+ "\nImproves mining speed and provides light.");
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
			player.AddBuff(BuffID.Mining, 2);
			player.AddBuff(BuffID.Shine, 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 12);
			recipe.AddIngredient(ItemID.Amethyst, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.MiningPotion, 1);
			recipe.AddIngredient(ItemID.ShinePotion, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}