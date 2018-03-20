using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons          //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class Eliminator : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ghastly weapon combines mechanical and organic parts.");
		}
        public override void SetDefaults()
        {
            item.damage = 20;  //The damage stat for the Weapon.
            item.ranged = true;    //This defines if it does Ranged damage and if its effected by Ranged increasing Armor/Accessories.
            item.width = 42;  //The size of the width of the hitbox in pixels.
            item.height = 16;    //The size of the height of the hitbox in pixels.
            item.useTime = 6;   //How fast the Weapon is used.
            item.useAnimation = 6;     //How long the Weapon is used for.
            item.useStyle = 5;   //The way your Weapon will be used, 1 is the regular sword swing for example
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 1.25f;  //The knockback stat of your Weapon.
            item.UseSound = SoundID.NPCHit9; //The sound played when using your Weapon
            item.value = Item.buyPrice(0, 12, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 3;   //The color the title of your Weapon when hovering over it ingame  
            item.autoReuse = true;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 10;
			item.useAmmo = AmmoID.Bullet;
            item.shootSpeed = 20f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
		
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				if (Main.rand.Next(100) < 7)
				{
					type = ProjectileID.ExplosiveBullet;
				} 
				
				else
					
				type = ProjectileID.BulletHighVelocity; // or ProjectileID.FireArrow;
			}
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 6);
			recipe.AddIngredient(mod, "HorrificTooth", 5);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 6);
			recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 6);
			recipe.AddIngredient(mod, "HorrificTooth", 5);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 6);
			recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}