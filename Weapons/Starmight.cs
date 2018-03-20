using SaobiesMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Weapons
{
	public class Starmight : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Crashing down like a mighty star."
					+ "\nShoots stars at enemies near the yoyo."
					+ "\nDespite being a yoyo, this is a magic weapon.");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 300;
			item.mana = 4;
			item.rare = 9;

			item.magic = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.buyPrice(1, 35, 20, 0);
			item.shoot = mod.ProjectileType<StarmightYoyoProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 15);
			recipe.AddIngredient(ItemID.Terrarian, 1);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}
