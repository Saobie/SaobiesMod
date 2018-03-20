using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class RootedBloom : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ancient flower that symbolizes the prosperity and resilience of life."
							+ "\nFlower petals explode out of enemies hit by it."
							+ "\nSaps life from foes.");
		}
        public override void SetDefaults()
        {          
			item.damage = 810;
            item.width = 30;
            item.height = 10;           
            item.value = Item.sellPrice(1, 20, 0, 0);
            item.rare = 3;
            item.noMelee = true; // Makes sure that the animation when using the item doesn't hurt NPCs.
            item.useStyle = 5; // Set the correct useStyle.
            item.useAnimation = 40; // Determines how long the animation lasts.
            item.useTime = 40; // Determines how fast you can use this weapon (a lower value results in a faster use time).
            item.knockBack = 7.5F;
            item.scale = 2F;
            item.noUseGraphic = true; // Do not use the item graphic when using the item (we just want the ball to spawn).
            item.shoot = mod.ProjectileType("RootedBloomBall");
            item.shootSpeed = 18.1F;
            item.UseSound = SoundID.Item1;
			item.melee = true;
            item.thrown = true; // Deals melee damage.
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AncientLifeShard", 1);
			recipe.AddIngredient(mod, "AncientLifewood", 125);
			recipe.AddIngredient(ItemID.LifeFruit, 2);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.FlowerPow, 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
