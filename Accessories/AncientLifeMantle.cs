using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class AncientLifeMantle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Birds sing after a storm. Why should we not also delight in what sunshine may greet us?"
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
			recipe.AddIngredient(null, "AncientLifewood", 125);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.LifeFruit, 2);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}