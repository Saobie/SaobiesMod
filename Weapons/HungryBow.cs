using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace SaobiesMod.Items.Weapons
{
	public class HungryBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bow made from parts of a horrible monster. Feels as though it has a mind of its own.");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
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
			item.value = Item.buyPrice(0, 14, 45, 80);
			item.rare = 3;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 3;
			item.UseSound = SoundID.NPCDeath13; 
			item.autoReuse = true;
			item.shootSpeed = 13f;
		}
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 12);
			recipe.AddIngredient(mod, "HorribleClump", 21);
			recipe.AddIngredient(mod, "GhastlyHeart", 2);
			recipe.AddIngredient(ItemID.RottenChunk, 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 12);
			recipe.AddIngredient(mod, "HorribleClump", 21);
			recipe.AddIngredient(mod, "GhastlyHeart", 2);
			recipe.AddIngredient(ItemID.Vertebrae, 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("LeechArrow"), damage, knockBack, player.whoAmI, 0f, 0f);
			return false;
		}
	}
}