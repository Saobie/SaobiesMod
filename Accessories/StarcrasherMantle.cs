using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class StarcrasherMantle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Stretching his hand to reach the stars, too often does man forget the flowers at his feet."
						+ "\nImproved running speed.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 90, 0, 0);
			item.rare = 9;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 200;
			player.maxRunSpeed += 3f;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.9f;
			ascentWhenRising = 0.18f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3.2f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 10f;
			acceleration *= 3f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 8);
			recipe.AddIngredient(mod, "SyntheticWings", 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}