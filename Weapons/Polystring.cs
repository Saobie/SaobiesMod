using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace SaobiesMod.Items.Weapons
{
	public class Polystring : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bow made of Polytithrite. Superbly forged with enchanted metal."
					 + "\nConverts wooden arrows into drillheaded arrows.");
		}
		public override void SetDefaults()
		{
			item.damage = 26;
			item.noMelee = true;
			item.ranged = true;
			item.width = 30;
			item.height = 50;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.shoot = 3;
			item.useAmmo = 1;
			item.knockBack = 1;
			item.value = Item.buyPrice(0, 35, 45, 80);
			item.rare = 3;
			item.shoot = 3;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item108; 
			item.autoReuse = true;
			item.shootSpeed = 18f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
		
			if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
			{
				type = mod.ProjectileType("PolydrillArrow"); // or ProjectileID.FireArrow;
			}
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteBar", 11);
			recipe.AddIngredient(ItemID.Diamond, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}