using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

namespace SaobiesMod.Items.Weapons
{
	public class Plexistring : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bow made of Plexicite. Expertly forged.");
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
			item.value = Item.buyPrice(0, 8, 45, 80);
			item.rare = 3;
			item.shoot = 3;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5; 
			item.autoReuse = true;
			item.shootSpeed = 13f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 11);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}