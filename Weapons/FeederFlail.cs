using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class FeederFlail : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Clump of flesh and teeth pulled from a horrible monster. Surely effective at tearing flesh from bone.");
		}
        public override void SetDefaults()
        {          
			item.damage = 44;
            item.width = 30;
            item.height = 10;           
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 3;
            item.noMelee = true; // Makes sure that the animation when using the item doesn't hurt NPCs.
            item.useStyle = 5; // Set the correct useStyle.
            item.useAnimation = 40; // Determines how long the animation lasts.
            item.useTime = 40; // Determines how fast you can use this weapon (a lower value results in a faster use time).
            item.knockBack = 7.5F;
            item.scale = 2F;
            item.noUseGraphic = true; // Do not use the item graphic when using the item (we just want the ball to spawn).
            item.shoot = mod.ProjectileType("FeederFlailBall");
            item.shootSpeed = 18.1F;
            item.UseSound = SoundID.Item1;
            item.melee = true; // Deals melee damage.
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 16);
			recipe.AddIngredient(mod, "HorribleClump", 18);
			recipe.AddIngredient(mod, "GhastlyHeart", 1);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 16);
			recipe.AddIngredient(mod, "HorribleClump", 18);
			recipe.AddIngredient(mod, "GhastlyHeart", 1);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			target.AddBuff(BuffID.Venom, 540);
			player.statLife += 5;
			player.HealEffect(5);
			
		/*	if (Main.rand.Next(5) == 0)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, ProjectileID.Flamelash, damage, Main.myPlayer);    
			}  */
		}
	}
}
