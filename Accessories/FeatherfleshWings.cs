using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class FeatherfleshWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Wings made from parts of a horrible monster."
			+ "\nWhat monsterous procedure did you do to make these?"
			+ "\n15% increased movement speed.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.rare = 5;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 120;
		}
		public override void UpdateEquip(Player player)
		{
			player.maxRunSpeed += 0.15f;
		}
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.9f;
			ascentWhenRising = 0.19f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 2f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 8f;
			acceleration *= 2.2f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 9);
			recipe.AddIngredient(mod, "HorribleClump", 12);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 16);
			recipe.AddIngredient(ItemID.Feather, 20);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 9);
			recipe.AddIngredient(mod, "HorribleClump", 12);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 16);
			recipe.AddIngredient(ItemID.Feather, 20);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}